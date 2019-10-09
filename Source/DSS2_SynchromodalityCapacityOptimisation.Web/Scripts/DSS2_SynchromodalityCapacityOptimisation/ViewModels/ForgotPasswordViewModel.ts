// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS2_SynchromodalityCapacityOptimisation.ViewModels.ForgotPassword {
export class ForgotPasswordViewModel extends DSS2_SynchromodalityCapacityOptimisation.ViewModels.MasterPage.MasterPageViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
txtUsername:
                true
            }
        } else {
            this._members["txtUsername"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: ForgotPasswordViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): ForgotPasswordViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        ForgotPasswordViewModel = new ForgotPasswordViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateForgotPasswordViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateForgotPasswordViewModel(original: ForgotPasswordViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if(original.txtUsername !== undefined) this.txtUsername = original.txtUsername;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = ForgotPasswordViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            ForgotPasswordViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): ForgotPasswordViewModel {
        var reduced = ForgotPasswordViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        ForgotPasswordViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: ForgotPasswordViewModel) {
        if (reduced == null) return;


        DSS2_SynchromodalityCapacityOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public txtUsername:
    any;
}

}
