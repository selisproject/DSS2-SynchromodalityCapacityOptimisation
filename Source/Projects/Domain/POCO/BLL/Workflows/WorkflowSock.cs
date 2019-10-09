// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using Identity = zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity;
using DSS2_SynchromodalityCapacityOptimisation.DAL;
using Newtonsoft.Json;
using zAppDev.DotNet.Framework.Workflow;
using zAppDev.DotNet.Framework.Identity.Model;

namespace DSS2_SynchromodalityCapacityOptimisation.BO
{
    #region Implementation
    public class WorkflowSockWorkflow : WorkflowImplementation
    {

        public override WorkflowContextBase GetContext()
        {
            return Context;
        }

        #region Step Fields
        private readonly WorkflowSockReconnectSockets ReconnectSockets = new WorkflowSockReconnectSockets();
        #endregion
        public override WorkflowStatus? Execute()
        {
            return Run();
        }
        #region Context
        public override WorkflowStatus? Status
        {
            get
            {
                return Context.Status;
            }
            set
            {
                Context.Status = value;
            }
        }
        public DSS2_SynchromodalityCapacityOptimisation.BO.WorkflowSockContext Context;
        #endregion
        public WorkflowSockWorkflow()
        {
            Context = new DSS2_SynchromodalityCapacityOptimisation.BO.WorkflowSockContext();
            Context.Name = this.GetType().Name;
            Status = WorkflowStatus.None;
        }
        public WorkflowStatus? ReconnectSocketsStep(bool run = true)
        {
            ReconnectSockets.Context = Context;
            if (run)
            {
                return ReconnectSockets.Run();
            }
            return WorkflowStatus.Completed;
        }
        public WorkflowExecutionResult RunAndGetResult()
        {
            var result = Run();
            return new WorkflowExecutionResult { Status = result, Context = Context };
        }
        public WorkflowStatus? Run()
        {
            try
            {
                if (ReconnectSocketsStep() == WorkflowStatus.Pending) return WorkflowStatus.Pending;
                return WorkflowStatus.Completed;
                Status = WorkflowStatus.Completed;
            }
            catch (Exception e)
            {
                Context.Error = $"Message: {e.Message}\n StackTrace: {e.StackTrace}";
                log4net.LogManager.GetLogger(GetType()).Error($"Error running workflow 'WorkflowSock'!", e);
                return WorkflowStatus.Failed;
            }
        }
        public override T GetStep<T>()
        {
            var stepName = typeof (T).Name;
            if (stepName == WorkflowSockReconnectSockets.StepName)
            {
                ReconnectSocketsStep(false);
                return ReconnectSockets as T;
            }
            return null;
        }
        public override WorkflowStatus? Continue(string stepName)
        {
            try
            {
                return WorkflowStatus.StepToContinueNotFound;
            }
            catch (Exception e)
            {
                Context.Error = $"Message: {e.Message}\n StackTrace: {e.StackTrace}";
                log4net.LogManager.GetLogger(GetType()).Error($"Error continuing workflow 'WorkflowSock'", e);
                throw;
            }
        }

        public override void CreatePendingJob(string stepName)
        {
            string user = null;
            try
            {
                user = Identity.IdentityHelper.GetCurrentUserName();
            }
            catch (Exception e)
            {
                Context.Error = $"Message: {e.Message}\n StackTrace: {e.StackTrace}";
                log4net.LogManager.GetLogger(GetType()).Warn("Could not get Current User while creating a Pending Job", e);
            }
            Context.PendingJobCreatedBy = user;
            Context.PendingStep = stepName;
            Context.PendingSince = DateTime.UtcNow;
            Status = WorkflowStatus.Pending;
            new DAL.Repository().Save(Context);
        }

        public override void RestoreState(WorkflowContextBase state)
        {
            Context = state as DSS2_SynchromodalityCapacityOptimisation.BO.WorkflowSockContext;
        }
    }
    #endregion
    #region Steps
    public class WorkflowSockReconnectSockets : IWorkflowStep
    {
        public static string StepName => "ReconnectSockets";
        public DSS2_SynchromodalityCapacityOptimisation.BO.WorkflowSockContext Context
        {
            get;
            set;
        }
        public Guid? Id
        {
            get;
            set;
        }
        private bool ShouldRun()
        {
            if (!ClaimPermission.CheckAccess(ClaimTypes.IDEF0Activity, "WorkflowSock", "ReconnectSockets"))
            {
                IdentityHelper.LogAction("WorkflowSock", "ReconnectSockets", false, "Unauthorized");
                throw new UnauthorizedAccessException("You do not have permissions to execute step 'ReconnectSockets' of 'WorkflowSock' Workflow");
            }
            return true;
        }
        public WorkflowStatus? Run()
        {
            if (!ShouldRun()) return WorkflowStatus.Completed;
            zAppDev.DotNet.Framework.Sockets.SocketClient socket = null;
            try
            {
                socket = zAppDev.DotNet.Framework.Sockets.SocketClient.GetConnection("SarmedPortal");
            }
            catch (System.Exception e)
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "WorkflowSockReconnectSockets",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, e.Message);
            }
            try
            {
                if ((socket == null || ((socket.IsConnected) == false)))
                {
                    if ((socket != null))
                    {
                        zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "WorkflowSockReconnectSockets",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Socket disconnected. Reconnecting...");
                        zAppDev.DotNet.Framework.Sockets.SocketClient.CloseConnection("SarmedPortal");
                    }
                    DSS2_SynchromodalityCapacityOptimisation.BO.PubSubExtensions.SubscribeOrders();
                    zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "WorkflowSockReconnectSockets",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Socket reconnected successfully!");
                }
            }
            catch (System.Exception x)
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "WorkflowSockReconnectSockets",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, x.Message);
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Error, "WorkflowSockReconnectSockets",  DSS2_SynchromodalityCapacityOptimisation.Hubs.EventsHub.RaiseDebugMessage, x.StackTrace);
            }
            return WorkflowStatus.Completed;
        }
    }

    #endregion
}
