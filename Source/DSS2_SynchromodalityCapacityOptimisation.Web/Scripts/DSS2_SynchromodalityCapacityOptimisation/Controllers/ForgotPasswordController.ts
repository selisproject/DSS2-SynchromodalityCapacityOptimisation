// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
$(document).keyup((e) => {
    if (e.which === 13 && Joove.Common.eventPreventsDefaultFormAction(e as JQueryEventObject) === false && !$(e.target).parent().hasClass("search-element")) {
        window._popUpManager.previouslyFocusedElement = document.activeElement;
        $(":focus").blur();
        Joove.Core.getScope().eventCallbacks.btnChangePasswordClicked(e);
    }
});
interface Window { scope_ForgotPassword: DSS2_SynchromodalityCapacityOptimisation.Controllers.IForgotPasswordScope; }
namespace DSS2_SynchromodalityCapacityOptimisation.Controllers {
const ForgotPasswordConditionalFormattings = [
new Joove.JbRule({
name: "HidePanelConditional",
type: Joove.RuleTypes.ConditionalFormatting,
isDataSetRule: false,
evaluatedAtServer: false,
contextControlName: null,


condition: async (_parents) => {
        return Joove.Common.nullSafe<any>(() => window._context.currentAction == "ResetPassword", false);

    },
evaluationTimes: [Joove.EvaluationTimes.OnLoad,Joove.EvaluationTimes.OnSubmit,Joove.EvaluationTimes.OnChange],
isRelatedToDataValidation: false
}),
        ];
const ForgotPasswordDataValidations = [
new Joove.JbRule({
name: "UsernameIsEmptyValidation",
type: Joove.RuleTypes.DataValidation,
evaluatedAtServer: false,
isDataSetRule: false,
group: "",



condition: async (_parents) => {
        return Joove.Common.nullSafe<any>(() => CLMS.Framework.String.IsNullOrEmpty(Joove.Common.nullSafe(function () {
            return Joove.Common.nullSafe<any>(() => window["scope_ForgotPassword"].model.txtUsername, "").trim();
        }, "")), false);


    },
expression: async function(_parents) {
        return Joove.Common.nullSafe<any>(() => window._resourcesManager.getLocalResource("RES_DATAVALIDATION_MESSAGE_UsernameIsEmpty", false), "");
    },
dataValidationMessageType:  Joove.DataValidationMessageType.INFO,
evaluationTimes: [Joove.EvaluationTimes.OnSubmit],
originalName: 'UsernameIsEmpty',
fromMasterPage: false
}),
                                      ];
const ForgotPasswordCalculatedExpressions = [
        ];

// Datasets Column Info

// Datasets Projection Shemas


export interface IForgotPasswordScope extends Joove.IWebPageScope {
model:
    DSS2_SynchromodalityCapacityOptimisation.ViewModels.ForgotPassword.ForgotPasswordViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,
UsernameIsEmpty: Joove.Validation.BindingEntry,txtUsername: Joove.Validation.BindingEntry,
    },
    _masterValidations?: any;
}

class ForgotPasswordController {
private timeoutDelayLockbtnChangePasswordClicked:
    any;
private timeoutDelayLockButton11Clicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_ForgotPassword.model = window.scope_ForgotPassword.dehydrate();
        //window.scope_MasterPage.model = window.scope_ForgotPassword.model;
        DSS2_SynchromodalityCapacityOptimisation.ViewModels.ForgotPassword.ForgotPasswordViewModel._lightCast(window.scope_ForgotPassword.model);
        // Joove.Common.applyScope(window.scope_ForgotPassword);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IForgotPasswordScope, $timeout: ng.ITimeoutService) {
        window.scope_ForgotPassword = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS2_SynchromodalityCapacityOptimisation.ViewModels.ForgotPassword.ForgotPasswordViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPage._validations;
        $scope._validations = { summary:
                                [],
                                UsernameIsEmpty:
                                { rule: ForgotPasswordDataValidations[0], group: ForgotPasswordDataValidations[0].group },
                                txtUsername:
                                { requiredControlId: 'txtUsername', group: null },
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: IForgotPasswordScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS2_SynchromodalityCapacityOptimisation.ViewModels.ForgotPassword.ForgotPasswordViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPage.model = $scope.model;

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
Render:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("ForgotPassword", "Render", "GET", [], {}, _modalOptions);
            },
ResetPasswordRequest:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'ForgotPassword', action: 'ResetPasswordRequest',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
ResetPassword:
            async (username, key, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("ForgotPassword", "ResetPassword", "GET", [username, key], {}, _modalOptions);
            },
        };
// Events
        $scope.eventCallbacks = {
btnChangePasswordClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockbtnChangePasswordClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockbtnChangePasswordClicked);
                }

                this.timeoutDelayLockbtnChangePasswordClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.ResetPasswordRequest(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: true });
                }, 0);
            },

Button11Clicked:
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
        window._ruleEngine.addDataValidations(ForgotPasswordDataValidations);
        window._ruleEngine.addConditionalFormattings(ForgotPasswordConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(ForgotPasswordCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("ForgotPasswordController", ["$scope", "$timeout", ForgotPasswordController] as Array<string>);
}
