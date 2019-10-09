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
        var MasterPageForSlide;
        (function (MasterPageForSlide) {
            var MasterPageForSlideViewModel = (function (_super) {
                __extends(MasterPageForSlideViewModel, _super);
                function MasterPageForSlideViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Title: true
                        };
                    }
                    else {
                        _this._members["Title"] = true;
                    }
                    return _this;
                }
                MasterPageForSlideViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                MasterPageForSlideViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new MasterPageForSlideViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateMasterPageForSlideViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                MasterPageForSlideViewModel.prototype._hydrateMasterPageForSlideViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.Title !== undefined)
                        this.Title = original.Title;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = MasterPageForSlideViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        MasterPageForSlideViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                MasterPageForSlideViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = MasterPageForSlideViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    MasterPageForSlideViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                MasterPageForSlideViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                };
                MasterPageForSlideViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return MasterPageForSlideViewModel;
            }(BaseClass.ViewModel));
            MasterPageForSlide.MasterPageForSlideViewModel = MasterPageForSlideViewModel;
        })(MasterPageForSlide = ViewModels.MasterPageForSlide || (ViewModels.MasterPageForSlide = {}));
    })(ViewModels = DSS2_SynchromodalityCapacityOptimisation.ViewModels || (DSS2_SynchromodalityCapacityOptimisation.ViewModels = {}));
})(DSS2_SynchromodalityCapacityOptimisation || (DSS2_SynchromodalityCapacityOptimisation = {}));
