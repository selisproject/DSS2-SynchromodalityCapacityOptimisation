/// <reference types="sweetalert" />
declare namespace Joove {
    class MessageType {
        static Error: string;
        static Success: string;
        static Info: string;
        static Warning: string;
    }
    enum OpenPopUpTypes {
        PopUp = 1,
        Modal = 2,
    }
    class PopUpManager {
        spinnerId: string;
        showLoadingTimeout: any;
        hideLoadingTimeout: any;
        popUpVisible: boolean;
        confirmationVisible: boolean;
        openPopUpStack: any[];
        isIE: boolean;
        previouslyFocusedElement: any;
        resetFocus(): void;
        popUps: any[];
        readonly isLoading: boolean;
        registerPopUp(options: any): void;
        showPopUp(name: string): void;
        getModalParent(element: JQuery): HTMLElement;
        hidePopUp(name: string, dontCallCloseCb?: boolean): void;
        addToOpenPopUpStack(name: string, type: OpenPopUpTypes): void;
        removeFromOpenPopUpStack(name: string, type: OpenPopUpTypes): void;
        handleOpenPopUpStack(): void;
        hideAllPopUps(): void;
        destroyPopUp(name: string): void;
        error(title: string, message?: string, cb?: Function): void;
        success(title: string, message?: string, cb?: Function): void;
        warning(title: string, message?: string, cb?: Function): void;
        info(title: string, message?: string, cb?: Function): void;
        question(title: string, message?: string, cb?: Function): void;
        showModalControl(modalName: string, options?: any): void;
        hideModalControl(modalName: string, options?: any): void;
        toHTML(message: string): string;
        showSimplePopUp(type: SweetAlert.AlertType, title: string, message: string, cb: Function): void;
        showConfirmPopUp(type: SweetAlert.AlertType, title: string, message: string, okCb: Function, cancelCb: Function): void;
        showLoadingPopUp(timeoutOverride?: number): void;
        hideLoadingPopUp(timeoutOverride?: number): void;
        showCustomPopUp(options: {
            name?: string;
            overlay?: boolean;
            startMaximized?: boolean;
            width?: any;
            height?: any;
            okButton?: boolean;
            cancelButton?: boolean;
            draggable?: boolean;
            resizable?: boolean;
            mode?: string;
            minHeight?: number;
            url?: string;
            $elementContent?: JQuery;
            title: string | number | boolean;
            closeCallback?: Function;
            destroyOnHide?: boolean;
            okText?: string;
            okCallback?: Function;
            cancelText?: string;
            cancelCallback?: Function;
            onShowCallback?: Function;
            afterShowCallback?: Function;
            contentsHtml?: any;
            cssClass?: string;
            dismissible?: boolean;
        }): void;
        reloadContent(options: any, popup: any, runOnShowCallback: any): void;
        resizePopUp(options: any, popup: any): void;
        hideScrollbars(): void;
        showScrollbars(): void;
        disableMouseWheelScroll(): void;
        enableMouseWheelScroll(): void;
        disableKeyboardEvents(): void;
        enableKeyboardEvents(): void;
    }
}
