// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS2_SynchromodalityCapacityOptimisation.BO;
using DSS2_SynchromodalityCapacityOptimisation.UI.Controllers.ApplicationSettingForm;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.MasterPageForSlide;
using DSS2_SynchromodalityCapacityOptimisation.UI.Controllers.MasterPageForSlide;
namespace DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm
{
    public class ApplicationSettingFormViewModel : MasterPageForSlideViewModel
    {
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting ApplicationSetting;


        public ApplicationSettingFormViewModel()
        {
            ApplicationSetting = new zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (manager.Session.Contains(ApplicationSetting))
            {
                manager.Session.Evict(ApplicationSetting);
            }
        }

    }


    [OriginalType(typeof(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm.ApplicationSettingFormViewModel))]
    public class ApplicationSettingFormViewModelDTO : MasterPageForSlideViewModelDTO, IViewModelDTO<DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm.ApplicationSettingFormViewModel>
    {

        [JsonConstructor]
        public ApplicationSettingFormViewModelDTO() { }
        public ApplicationSettingFormViewModelDTO(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm.ApplicationSettingFormViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            ApplicationSetting = original.ApplicationSetting == null ? null : new ApplicationSetting_ApplicationSettingDTO(original.ApplicationSetting);
        }
        public ApplicationSetting_ApplicationSettingDTO ApplicationSetting;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm.ApplicationSettingFormViewModel).FullName;

        public new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm.ApplicationSettingFormViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm.ApplicationSettingFormViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm.ApplicationSettingFormViewModel();
        }
        new  public DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm.ApplicationSettingFormViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm.ApplicationSettingFormViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.ApplicationSettingForm.ApplicationSettingFormViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.ApplicationSetting = ApplicationSetting == null
                                          ? null
                                          : ApplicationSetting.Convert();
        }
    }

    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting))]
    public class ApplicationSetting_ApplicationSettingDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting>
    {

        [JsonConstructor]
        public ApplicationSetting_ApplicationSettingDTO() { }
        public ApplicationSetting_ApplicationSettingDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Id = original.Id;
            IsCustom = original.IsCustom;
            Key = original.Key;
            Value = original.Value;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public bool IsCustom;
        public string Key;
        public string Value;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting).FullName;
        public override List<string> _baseClasses => null;
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting();
            }
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting original)
        {
            if (original == null) return;
            original.Id = Id ?? 0;
            original.IsCustom = IsCustom;
            original.Key = Key;
            original.Value = Value;
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static ApplicationSetting_ApplicationSettingDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting>(parsedKey, true);
            if(foundEntry != null)
            {
                return new ApplicationSetting_ApplicationSettingDTO(foundEntry);
            }
            return null;
        }
    }



}
