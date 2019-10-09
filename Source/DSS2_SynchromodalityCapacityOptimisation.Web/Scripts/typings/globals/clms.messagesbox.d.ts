interface CLMSMessageBox {
    jMessageBox(message, title?, buttons?, type?, callback?, closeTime?);

    jMessageBoxAlert(message, title?, callback?, closeTime?);

    jMessageBoxConfirm(message, title?, callback?, buttons?);

    jMessageBoxError(message, title?, callback?, buttons?);

    jMessageBoxWarning(message, title?, callback?, buttons?);

    jMessageBoxCustomContent(message, title?, buttons?, type?, callback?, closeTime?, contents?, options?);

    jMessageBoxButtons: any;

}

declare enum jMessageBoxType {
    Error,
    Information,
    Question
}

declare enum jmessageBoxRespone {
    OK,
    Yes,
    No,
    Cancel
}

declare var CLMSMessageBox: CLMSMessageBox;