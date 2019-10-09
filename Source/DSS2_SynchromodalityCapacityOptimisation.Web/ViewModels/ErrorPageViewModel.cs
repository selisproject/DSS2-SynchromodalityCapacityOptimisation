// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS2_SynchromodalityCapacityOptimisation.BO;
using DSS2_SynchromodalityCapacityOptimisation.UI.Controllers.ErrorPage;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.MasterPageSignIn;
using DSS2_SynchromodalityCapacityOptimisation.UI.Controllers.MasterPageSignIn;
namespace DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage
{
    public class ErrorPageViewModel : MasterPageSignInViewModel
    {
        public string ErrorMessage;
        public string StackTrace;
        public string FriendlyErrorMessage;
        public string AdditionalErrorInformation;


        public ErrorPageViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage.ErrorPageViewModel))]
    public class ErrorPageViewModelDTO : MasterPageSignInViewModelDTO, IViewModelDTO<DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage.ErrorPageViewModel>
    {

        [JsonConstructor]
        public ErrorPageViewModelDTO() { }
        public ErrorPageViewModelDTO(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage.ErrorPageViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            ErrorMessage = original.ErrorMessage;
            StackTrace = original.StackTrace;
            FriendlyErrorMessage = original.FriendlyErrorMessage;
            AdditionalErrorInformation = original.AdditionalErrorInformation;
        }
        public string ErrorMessage;
        public string StackTrace;
        public string FriendlyErrorMessage;
        public string AdditionalErrorInformation;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage.ErrorPageViewModel).FullName;

        public new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage.ErrorPageViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage.ErrorPageViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage.ErrorPageViewModel();
        }
        new  public DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage.ErrorPageViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage.ErrorPageViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ErrorPage.ErrorPageViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.ErrorMessage = ErrorMessage;
            original.StackTrace = StackTrace;
            original.FriendlyErrorMessage = FriendlyErrorMessage;
            original.AdditionalErrorInformation = AdditionalErrorInformation;
        }
    }



}