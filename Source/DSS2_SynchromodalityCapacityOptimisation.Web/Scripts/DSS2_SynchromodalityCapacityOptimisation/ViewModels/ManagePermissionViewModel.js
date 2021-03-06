var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS2_SynchromodalityCapacityOptimisation;
(function (DSS2_SynchromodalityCapacityOptimisation) {
    var ViewModels;
    (function (ViewModels) {
        var ManagePermission;
        (function (ManagePermission) {
            var ManagePermissionViewModel = (function (_super) {
                __extends(ManagePermissionViewModel, _super);
                function ManagePermissionViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            ApplicationPermission: true
                        };
                    }
                    else {
                        _this._members["ApplicationPermission"] = true;
                    }
                    return _this;
                }
                ManagePermissionViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.ApplicationPermission != null)
                        instance.ApplicationPermission = ApplicationPermission_ApplicationPermissionViewModel._lightCast(instance.ApplicationPermission);
                    return instance;
                };
                ManagePermissionViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ManagePermissionViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateManagePermissionViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ManagePermissionViewModel.prototype._hydrateManagePermissionViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    this._hydrateMasterPageForSlideViewModel(original, ignoreReadOnlyProperties, context);
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original.ApplicationPermission !== undefined)
                        this.ApplicationPermission = ApplicationPermission_ApplicationPermissionViewModel._initializeFrom(original.ApplicationPermission, ignoreReadOnlyProperties, context);
                    this.Button4SelectedItemKeys = original.Button4SelectedItemKeys;
                    this.Button41SelectedItemKeys = original.Button41SelectedItemKeys;
                    this.Button5SelectedItemKeys = original.Button5SelectedItemKeys;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ManagePermissionViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        ManagePermissionViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ManagePermissionViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ManagePermissionViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    ManagePermissionViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                ManagePermissionViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS2_SynchromodalityCapacityOptimisation.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel._deleteDropDownInitialValues(reduced);
                };
                ManagePermissionViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ManagePermissionViewModel;
            }(DSS2_SynchromodalityCapacityOptimisation.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel));
            ManagePermission.ManagePermissionViewModel = ManagePermissionViewModel;
            var ApplicationPermission_ApplicationPermissionViewModel = (function (_super) {
                __extends(ApplicationPermission_ApplicationPermissionViewModel, _super);
                function ApplicationPermission_ApplicationPermissionViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Description: true, Id: true, Name: true, Operations: true, Roles: true, Users: true
                        };
                    }
                    else {
                        _this._members["Description"] = true;
                        _this._members["Id"] = true;
                        _this._members["Name"] = true;
                        _this._members["Operations"] = true;
                        _this._members["Roles"] = true;
                        _this._members["Users"] = true;
                    }
                    _this.Operations = new Array();
                    _this.Roles = new Array();
                    _this.Users = new Array();
                    return _this;
                }
                ApplicationPermission_ApplicationPermissionViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.Operations != null) {
                        for (var i = 0; i < instance.Operations.length; i++) {
                            instance.Operations[i] = ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel._lightCast(instance.Operations[i]);
                        }
                    }
                    if (instance.Roles != null) {
                        for (var i = 0; i < instance.Roles.length; i++) {
                            instance.Roles[i] = ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel._lightCast(instance.Roles[i]);
                        }
                    }
                    if (instance.Users != null) {
                        for (var i = 0; i < instance.Users.length; i++) {
                            instance.Users[i] = ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel._lightCast(instance.Users[i]);
                        }
                    }
                    return instance;
                };
                ApplicationPermission_ApplicationPermissionViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ApplicationPermission_ApplicationPermissionViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateApplicationPermission_ApplicationPermissionViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ApplicationPermission_ApplicationPermissionViewModel.prototype._hydrateApplicationPermission_ApplicationPermissionViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original._versionTimestamp !== undefined)
                        this._versionTimestamp = original._versionTimestamp;
                    if (original.Description !== undefined)
                        this.Description = original.Description;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (original.Name !== undefined)
                        this.Name = original.Name;
                    if (original.Operations != null) {
                        for (var i = 0; i < original.Operations.length; i++) {
                            this.Operations.push(ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel._initializeFrom(original.Operations[i], ignoreReadOnlyProperties, context));
                        }
                    }
                    if (original.Roles != null) {
                        for (var i = 0; i < original.Roles.length; i++) {
                            this.Roles.push(ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel._initializeFrom(original.Roles[i], ignoreReadOnlyProperties, context));
                        }
                    }
                    if (original.Users != null) {
                        for (var i = 0; i < original.Users.length; i++) {
                            this.Users.push(ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel._initializeFrom(original.Users[i], ignoreReadOnlyProperties, context));
                        }
                    }
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ApplicationPermission_ApplicationPermissionViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ApplicationPermission_ApplicationPermissionViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ApplicationPermission_ApplicationPermissionViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                ApplicationPermission_ApplicationPermissionViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ApplicationPermission_ApplicationPermissionViewModel;
            }(BaseClass.ViewModel));
            ManagePermission.ApplicationPermission_ApplicationPermissionViewModel = ApplicationPermission_ApplicationPermissionViewModel;
            var ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel = (function (_super) {
                __extends(ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel, _super);
                function ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Id: true, IsAvailableToAllAuthorizedUsers: true, IsAvailableToAnonymous: true, Name: true, ParentControllerName: true
                        };
                    }
                    else {
                        _this._members["Id"] = true;
                        _this._members["IsAvailableToAllAuthorizedUsers"] = true;
                        _this._members["IsAvailableToAnonymous"] = true;
                        _this._members["Name"] = true;
                        _this._members["ParentControllerName"] = true;
                    }
                    return _this;
                }
                ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel.prototype._hydrateApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original._versionTimestamp !== undefined)
                        this._versionTimestamp = original._versionTimestamp;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (ignoreReadOnlyProperties !== true) {
                        if (original.IsAvailableToAllAuthorizedUsers !== undefined)
                            this.IsAvailableToAllAuthorizedUsers = original.IsAvailableToAllAuthorizedUsers;
                    }
                    else {
                        delete this['IsAvailableToAllAuthorizedUsers'];
                        delete this._members['IsAvailableToAllAuthorizedUsers'];
                    }
                    if (ignoreReadOnlyProperties !== true) {
                        if (original.IsAvailableToAnonymous !== undefined)
                            this.IsAvailableToAnonymous = original.IsAvailableToAnonymous;
                    }
                    else {
                        delete this['IsAvailableToAnonymous'];
                        delete this._members['IsAvailableToAnonymous'];
                    }
                    if (ignoreReadOnlyProperties !== true) {
                        if (original.Name !== undefined)
                            this.Name = original.Name;
                    }
                    else {
                        delete this['Name'];
                        delete this._members['Name'];
                    }
                    if (ignoreReadOnlyProperties !== true) {
                        if (original.ParentControllerName !== undefined)
                            this.ParentControllerName = original.ParentControllerName;
                    }
                    else {
                        delete this['ParentControllerName'];
                        delete this._members['ParentControllerName'];
                    }
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel;
            }(BaseClass.ViewModel));
            ManagePermission.ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel = ApplicationPermission_ApplicationPermission_Operations_ApplicationOperationViewModel;
            var ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel = (function (_super) {
                __extends(ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel, _super);
                function ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Description: true, Id: true, Name: true
                        };
                    }
                    else {
                        _this._members["Description"] = true;
                        _this._members["Id"] = true;
                        _this._members["Name"] = true;
                    }
                    return _this;
                }
                ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel.prototype._hydrateApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original._versionTimestamp !== undefined)
                        this._versionTimestamp = original._versionTimestamp;
                    if (ignoreReadOnlyProperties !== true) {
                        if (original.Description !== undefined)
                            this.Description = original.Description;
                    }
                    else {
                        delete this['Description'];
                        delete this._members['Description'];
                    }
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (ignoreReadOnlyProperties !== true) {
                        if (original.Name !== undefined)
                            this.Name = original.Name;
                    }
                    else {
                        delete this['Name'];
                        delete this._members['Name'];
                    }
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel;
            }(BaseClass.ViewModel));
            ManagePermission.ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel = ApplicationPermission_ApplicationPermission_Roles_ApplicationRoleViewModel;
            var ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel = (function (_super) {
                __extends(ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel, _super);
                function ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Email: true, UserName: true
                        };
                    }
                    else {
                        _this._members["Email"] = true;
                        _this._members["UserName"] = true;
                    }
                    return _this;
                }
                ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel.prototype._hydrateApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original._versionTimestamp !== undefined)
                        this._versionTimestamp = original._versionTimestamp;
                    if (ignoreReadOnlyProperties !== true) {
                        if (original.Email !== undefined)
                            this.Email = original.Email;
                    }
                    else {
                        delete this['Email'];
                        delete this._members['Email'];
                    }
                    if (original.UserName !== undefined)
                        this.UserName = original.UserName;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel;
            }(BaseClass.ViewModel));
            ManagePermission.ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel = ApplicationPermission_ApplicationPermission_Users_ApplicationUserViewModel;
        })(ManagePermission = ViewModels.ManagePermission || (ViewModels.ManagePermission = {}));
    })(ViewModels = DSS2_SynchromodalityCapacityOptimisation.ViewModels || (DSS2_SynchromodalityCapacityOptimisation.ViewModels = {}));
})(DSS2_SynchromodalityCapacityOptimisation || (DSS2_SynchromodalityCapacityOptimisation = {}));
