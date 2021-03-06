// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS2_SynchromodalityCapacityOptimisation.BO;
using DSS2_SynchromodalityCapacityOptimisation.UI.Controllers.SignOutPage;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.MasterPage;
using DSS2_SynchromodalityCapacityOptimisation.UI.Controllers.MasterPage;
namespace DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage
{
    public class SignOutPageViewModel : MasterPageViewModel
    {


        public SignOutPageViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage.SignOutPageViewModel))]
    public class SignOutPageViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage.SignOutPageViewModel>
    {

        [JsonConstructor]
        public SignOutPageViewModelDTO() { }
        public SignOutPageViewModelDTO(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage.SignOutPageViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage.SignOutPageViewModel).FullName;

        public new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage.SignOutPageViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage.SignOutPageViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage.SignOutPageViewModel();
        }
        new  public DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage.SignOutPageViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage.SignOutPageViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.SignOutPage.SignOutPageViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
        }
    }



}
