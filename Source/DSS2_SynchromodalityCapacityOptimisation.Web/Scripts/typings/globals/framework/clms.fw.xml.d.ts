declare var _createMSXMLDocumentObject: any;
declare namespace System.Xml {
    interface Node {
        SelectSingleNode: (xpath: string) => Node;
        SelectNodes: (xpath: string) => Node[];
    }
    class XmlDocument {
        xmlDocument: XMLDocument;
        xmlString: string;
        constructor();
        readonly outerHTML: string;
        LoadXml(text: any): boolean;
        SelectSingleNode(xpath: string): any;
        SelectNodes(xpath: string): Node[];
    }
    class HtmlVisitor {
        constructor();
        visit(element: Element, apply: (parent: Element, current: Element) => void, root?: Element): void;
        toObject(element: Element, apply: (parent: any, current: Element) => any, root?: any): any;
    }
}
