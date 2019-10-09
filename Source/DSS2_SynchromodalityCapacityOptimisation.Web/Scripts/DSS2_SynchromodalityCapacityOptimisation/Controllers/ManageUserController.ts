// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
$(document).keyup((e) => {
    if (e.which === 13 && Joove.Common.eventPreventsDefaultFormAction(e as JQueryEventObject) === false && !$(e.target).parent().hasClass("search-element")) {
        window._popUpManager.previouslyFocusedElement = document.activeElement;
        $(":focus").blur();
        Joove.Core.getScope().eventCallbacks.SaveBtnClicked(e);
    }
});
window.onbeforeunload = (e) => {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg;     // Gecko, Trident, Chrome 34+
        return msg;
    }
};
interface Window { scope_ManageUser: DSS2_SynchromodalityCapacityOptimisation.Controllers.IManageUserScope; }
namespace DSS2_SynchromodalityCapacityOptimisation.Controllers {
const ManageUserConditionalFormattings = [
new Joove.JbRule({
name: "UserIsNewConditional",
type: Joove.RuleTypes.ConditionalFormatting,
isDataSetRule: false,
evaluatedAtServer: false,
contextControlName: null,


condition: async (_parents) => {
        return Joove.Common.nullSafe<any>(() => window._context.currentAction == "NewUser", false);

    },
evaluationTimes: [Joove.EvaluationTimes.OnLoad],
isRelatedToDataValidation: false
}),
new Joove.JbRule({
name: "HideOnNewOrSingedInConditional",
type: Joove.RuleTypes.ConditionalFormatting,
isDataSetRule: false,
evaluatedAtServer: false,
contextControlName: null,


condition: async (_parents) => {
        return Joove.Common.nullSafe<any>(() => window._context.currentAction == "NewUser", false) || Joove.Common.nullSafe<any>(() => window._context.currentUsername, "") == Joove.Common.nullSafe<any>(() => window["scope_ManageUser"].model.ApplicationUser.UserName, "");

    },
evaluationTimes: [Joove.EvaluationTimes.OnLoad],
isRelatedToDataValidation: false
}),
new Joove.JbRule({
name: "AdminCanSetPassConditional",
type: Joove.RuleTypes.ConditionalFormatting,
isDataSetRule: false,
evaluatedAtServer: false,
contextControlName: null,


condition: async (_parents) => {
        return Joove.Common.nullSafe<any>(() => window._context.adminCanSetPasswords, false);

    },
evaluationTimes: [Joove.EvaluationTimes.OnLoad,Joove.EvaluationTimes.OnSubmit,Joove.EvaluationTimes.OnChange],
isRelatedToDataValidation: false
}),
        ];
const ManageUserDataValidations = [
new Joove.JbRule({
name: "IsMailValidValidation",
type: Joove.RuleTypes.DataValidation,
evaluatedAtServer: false,
isDataSetRule: false,
group: "",



condition: async (_parents) => {
        return !(Joove.Common.nullSafe<any>(() => Joove.Common.isValidEmail(Joove.Common.nullSafe<any>(() => window["scope_ManageUser"].model.ApplicationUser.Email, "")), false));


    },
expression: async function(_parents) {
        return Joove.Common.nullSafe<any>(() => window._resourcesManager.getLocalResource("RES_DATAVALIDATION_MESSAGE_IsMailValid", false), "");
    },
dataValidationMessageType:  Joove.DataValidationMessageType.ERROR,
evaluationTimes: [Joove.EvaluationTimes.OnSubmit],
originalName: 'IsMailValid',
fromMasterPage: false
}),
                                  ];
const ManageUserCalculatedExpressions = [
                                        ];

// Datasets Column Info
var Button1_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "int",
dataTypeIsEnum: false,
name: "Id",
caption: window._resourcesManager.getDataListColumnCaption("Button1", "Id", true),
groupable: true,
searchable: false,
visible: false,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Name",
caption: window._resourcesManager.getDataListColumnCaption("Button1", "Name", true),
groupable: true,
searchable: false,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 255,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Description",
caption: window._resourcesManager.getDataListColumnCaption("Button1", "Description", true),
groupable: true,
searchable: false,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 1000,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
})] as any;
window["Button1_ColumnInfo"] = Button1_ColumnInfo;
var Button2_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "int",
dataTypeIsEnum: false,
name: "Id",
caption: window._resourcesManager.getDataListColumnCaption("Button2", "Id", true),
groupable: true,
searchable: false,
visible: false,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Name",
caption: window._resourcesManager.getDataListColumnCaption("Button2", "Name", true),
groupable: true,
searchable: false,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 255,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Description",
caption: window._resourcesManager.getDataListColumnCaption("Button2", "Description", true),
groupable: true,
searchable: false,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 1000,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
})] as any;
window["Button2_ColumnInfo"] = Button2_ColumnInfo;

// Datasets Projection Shemas
window["Button1_ProjectionScema"] = {};
window["Button2_ProjectionScema"] = {};


export interface IManageUserScope extends Joove.IWebPageScope {
model:
    DSS2_SynchromodalityCapacityOptimisation.ViewModels.ManageUser.ManageUserViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,
IsMailValid: Joove.Validation.BindingEntry,UserName: Joove.Validation.BindingEntry,Email: Joove.Validation.BindingEntry,
    },
    _masterValidations?: any;
}

class ManageUserController {
private timeoutDelayLockButtonClicked:
    any;
private timeoutDelayLockSaveBtnClicked:
    any;
private timeoutDelayLockDeleteBtnClicked:
    any;
private timeoutDelayLockExitBtnClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_ManageUser.model = window.scope_ManageUser.dehydrate();
        //window.scope_MasterPageForSlide.model = window.scope_ManageUser.model;
        DSS2_SynchromodalityCapacityOptimisation.ViewModels.ManageUser.ManageUserViewModel._lightCast(window.scope_ManageUser.model);
        // Joove.Common.applyScope(window.scope_ManageUser);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IManageUserScope, $timeout: ng.ITimeoutService) {
        window.scope_ManageUser = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS2_SynchromodalityCapacityOptimisation.ViewModels.ManageUser.ManageUserViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPageForSlide._validations;
        $scope._validations = { summary:
                                [],
                                IsMailValid:
                                { rule: ManageUserDataValidations[0], group: ManageUserDataValidations[0].group },
                                UserName:
                                { requiredControlId: 'UserName', group: null },
                                Email:
                                { requiredControlId: 'Email', group: null },
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: IManageUserScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS2_SynchromodalityCapacityOptimisation.ViewModels.ManageUser.ManageUserViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPageForSlide.model = $scope.model;

        new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
        $scope.trackObject = obj => Joove.Common.trackObject(obj);


        //}

        $.connection['eventsHub'].on('__connectedEvent');

        $.connection['eventsHub'].on('forcePageReload', () => {
            window.onbeforeunload = null;
            setTimeout(() => {
                window.location.reload();
            }, 3000);
        });
        $.connection.hub.start(() => {
            Joove.Common.getScope().connectedToSignals();
            Joove.Common.getMasterScope().connectedToSignals();

        });
        $scope.connectedToSignals = () => {
        }
// Event Listeners
        $scope.events = {
        };
        $scope.expressions = {
        }
// Dataset Handler
        $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
NewUser:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("ManageUser", "NewUser", "GET", [], {}, _modalOptions);
            },
EditUser:
            async (Id, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("ManageUser", "EditUser", "GET", [Id], {}, _modalOptions);
            },
SaveUser:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'ManageUser', action: 'SaveUser',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
DeleteUser:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'ManageUser', action: 'DeleteUser',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
SetPassword:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'ManageUser', action: 'SetPassword',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
        };
// Events
        $scope.eventCallbacks = {
ButtonClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockButtonClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockButtonClicked);
                }

                this.timeoutDelayLockButtonClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);
                    window._popUpManager.question(window._resourcesManager.getGlobalResource("RES_WEBFORM_GenericConfirmationQuestion"),
                    window._resourcesManager.getEventConfirmation("Button", false), (isConfirm) => {
                        if (!isConfirm) return;

                        setTimeout(() => {

                            Joove.Validation.Manager.validateFormAndExecute(() => {
                                $scope.actions.SetPassword(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 1000);
                    });
                }, 0);
            },

SaveBtnClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockSaveBtnClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockSaveBtnClicked);
                }

                this.timeoutDelayLockSaveBtnClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.SaveUser(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: true });
                }, 0);
            },

DeleteBtnClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockDeleteBtnClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockDeleteBtnClicked);
                }

                this.timeoutDelayLockDeleteBtnClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);
                    window._popUpManager.question(window._resourcesManager.getGlobalResource("RES_WEBFORM_GenericConfirmationQuestion"),
                    window._resourcesManager.getEventConfirmation("DeleteBtn", false), (isConfirm) => {
                        if (!isConfirm) return;

                        setTimeout(() => {

                            Joove.Validation.Manager.validateFormAndExecute(() => {
                                $scope.actions.DeleteUser(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 1000);
                    });
                }, 0);
            },

ExitBtnClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                Joove.Common.setControlKeyPressed(e, 0);
                window._commander.closeForm();
            },

        };

// Rules
        window._ruleEngine.addDataValidations(ManageUserDataValidations);
        window._ruleEngine.addConditionalFormattings(ManageUserConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(ManageUserCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageForSlide as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("ManageUserController", ["$scope", "$timeout", ManageUserController] as Array<string>);
}
