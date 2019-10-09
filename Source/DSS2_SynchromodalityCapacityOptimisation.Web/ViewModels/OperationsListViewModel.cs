// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS2_SynchromodalityCapacityOptimisation.BO;
using DSS2_SynchromodalityCapacityOptimisation.UI.Controllers.OperationsList;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.MasterPage;
using DSS2_SynchromodalityCapacityOptimisation.UI.Controllers.MasterPage;
namespace DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList
{
    public class OperationsListViewModel : MasterPageViewModel
    {
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> ListSelectedItems;


        public OperationsListViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList.OperationsListViewModel))]
    public class OperationsListViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList.OperationsListViewModel>
    {

        [JsonConstructor]
        public OperationsListViewModelDTO() { }
        public OperationsListViewModelDTO(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList.OperationsListViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            ListSelectedItemKeys = original.ListSelectedItems == null
                                   ? null
                                   : original.ListSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList.OperationsListViewModel).FullName;
        public List<SelectedItemInfo<int?>> ListSelectedItemKeys;

        public new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList.OperationsListViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList.OperationsListViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList.OperationsListViewModel();
        }
        new  public DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList.OperationsListViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList.OperationsListViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS2_SynchromodalityCapacityOptimisation.UI.ViewModels.OperationsList.OperationsListViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.ListSelectedItems = ListSelectedItemKeys == null
                                         ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                         : ListSelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.OperationsList.List1DataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation))]
    [DataSetDTO]
    public class List1DataSet_ApplicationOperationDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>
    {
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string ParentControllerName;
        public string Name;
        public bool IsAvailableToAllAuthorizedUsers;
        public bool IsAvailableToAnonymous;


        [JsonConstructor]
        public List1DataSet_ApplicationOperationDTO() : base() {}
        public  static List1DataSet_ApplicationOperationDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new OperationsListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new List1DataSet_ApplicationOperationDTO(foundEntry);
            }
            return null;
        }
        public List1DataSet_ApplicationOperationDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public List1DataSet_ApplicationOperationDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.Id == 0) ? original._GetUniqueIdentifier() as object : original.Id as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            Id = original.Id;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            ParentControllerName = original.ParentControllerName;
            Name = original.Name;
            IsAvailableToAllAuthorizedUsers = original.IsAvailableToAllAuthorizedUsers;
            IsAvailableToAnonymous = original.IsAvailableToAnonymous;
        }

        public static zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation Convert()
        {
            var model = new zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.ParentControllerName = ParentControllerName;
            model.Name = Name;
            model.IsAvailableToAllAuthorizedUsers = IsAvailableToAllAuthorizedUsers;
            model.IsAvailableToAnonymous = IsAvailableToAnonymous;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    #endregion

}
