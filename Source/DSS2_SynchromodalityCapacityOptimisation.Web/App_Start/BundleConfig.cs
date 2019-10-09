// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System.Web.Optimization;
using System.Collections.Generic;
using zAppDev.DotNet.Framework.Mvc;

namespace DSS2_SynchromodalityCapacityOptimisation.Web
{
    public class BundleConfig
    {
        public class VersionBundleTransform : IBundleTransform
        {
            public void Process(BundleContext context, BundleResponse response)
            {
                foreach (var file in response.Files)
                {
                    file.IncludedVirtualPath = $"{file.IncludedVirtualPath}?v={AppCode.BaseViewPage<object>.AppVersion}";
                }
            }
        }//end VersionBundleTransform()

        public static void RegisterBundles(BundleCollection bundles)
        {
#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
            bundles.Add(new ScriptBundle("~/bundle/scripts/clms-framework")
                        .Include(
                            "~/Scripts/Clms-Framework/clms.fw.back.end.info.aggregator.js",
                            "~/Scripts/Clms-Framework/clms.fw.performance.manager.js",
                            "~/Scripts/Clms-Framework/clms.fw.client.commander.js",
                            "~/Scripts/Clms-Framework/clms.fw.dotnet.js",
                            "~/Scripts/Clms-Framework/clms.fw.dotnet.linq.js",
                            "~/Scripts/Clms-Framework/clms.fw.resource.manager.js",
                            "~/Scripts/Clms-Framework/clms.fw.popup.manager.js",
                            "~/Scripts/Clms-Framework/clms.fw.theme.manager.js",
                            "~/Scripts/Clms-Framework/clms.fw.ajax.js",
                            "~/Scripts/Clms-Framework/clms.fw.friendly.error.message.js",
                            "~/Scripts/Clms-Framework/clms.fw.base.classes.js",
                            "~/Scripts/Clms-Framework/clms.fw.references.reconstructor.js",
                            "~/Scripts/Clms-Framework/clms.fw.core.js",
                            "~/Scripts/Clms-Framework/clms.fw.datasources.js",
                            "~/Scripts/Clms-Framework/clms.fw.cf.helper.js",
                            "~/Scripts/Clms-Framework/clms.fw.common.js",
                            "~/Scripts/Clms-Framework/clms.fw.cycles.js",
                            "~/Scripts/Clms-Framework/clms.fw.rule.engine.js",
                            "~/Scripts/Clms-Framework/clms.fw.validation.js",
                            "~/Scripts/Clms-Framework/clms.fw.angular.js",
                            "~/Scripts/Clms-Framework/clms.fw.debug.js",
                            "~/Scripts/Clms-Framework/clms.fw.developer.api.js",
                            "~/Scripts/Clms-Framework/clms.fw.globalization.js",
                            "~/Scripts/Clms-Framework/clms.fw.xml.js",
                            "~/Scripts/Clms-Framework/clms.fw.recorder.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundle/scripts/dependencies")
                        .Include(
                            //"~/Scripts/Third-Party/jquery-1.9.1.min.js",	//EnableOptimizations generates incorrect jquery minified code in some cases
                            "~/Scripts/Third-Party/angular.min.js",
                            "~/Scripts/Third-Party/angular-sanitize.js",
                            "~/Scripts/Third-Party/swal/sweetalert.min.js",
                            "~/Scripts/Third-Party/moment-with-locales.min.js",
                            "~/Scripts/Third-Party/jquery-ui-1.12.1.min.js",
                            "~/Scripts/Third-Party/axios.min.js",
                            "~/Scripts/Third-Party/es6-promise.auto.js"
                        ));
            var dataListJsBundle = new ScriptBundle("~/Scripts/Controls/DataList/clms.data.list.bundle.js")
            .Include(
                "~/Scripts/Controls/DataList/clms.data.list.js",
                "~/Scripts/Third-Party/jquery.ui-contextmenu.js",
                "~/Scripts/Third-Party/DataTables/DataTables-1.10.15/js/jquery.dataTables.js",		//Custom patched file not same as min
                "~/Scripts/Third-Party/DataTables/DataTables-1.10.15/js/dataTables.bootstrap.js",
                "~/Scripts/Third-Party/DataTables/Responsive-2.1.1/js/responsive.bootstrap.min.js",
                "~/Scripts/Third-Party/DataTables/FixedHeader-3.1.2/js/dataTables.fixedHeader.min.js",
                "~/Scripts/Third-Party/DataTables/ColReorder-1.3.3/js/dataTables.colReorder.js",	//Custom patched file not same as min
                "~/Scripts/Third-Party/DataTables/Buttons-1.3.1/js/dataTables.buttons.min.js",
                "~/Scripts/Third-Party/DataTables/Buttons-1.3.1/js/buttons.bootstrap.js",			//Custom patched file not same as min
                "~/Scripts/Third-Party/DataTables/Buttons-1.3.1/js/buttons.colVis.js",				//Custom patched file not same as min
                "~/Scripts/Third-Party/DataTables/Buttons-1.3.1/js/buttons.html5.min.js",
                "~/Scripts/Third-Party/DataTables/Buttons-1.3.1/js/buttons.print.min.js",
                "~/Scripts/Third-Party/DataTables/Buttons-1.3.1/js/buttons.flash.min.js",
                "~/Scripts/Third-Party/DataTables/Select-1.2.2/js/dataTables.select.js");
            dataListJsBundle.Orderer = new NonOrderingBundleOrderer();
            bundles.Add(dataListJsBundle);
            bundles.Add(new StyleBundle("~/Scripts/Third-Party/DataTables/bundle/css/style.css")
                        .Include(
                            "~/Scripts/Controls/DataList/clms.data.list.css",
                            "~/Scripts/Third-Party/DataTables/DataTables-1.10.15/css/dataTables.bootstrap.min.css",
                            "~/Scripts/Third-Party/DataTables/Responsive-2.1.1/css/responsive.bootstrap.min.css",
                            "~/Scripts/Third-Party/DataTables/FixedHeader-3.1.2/css/fixedHeader.bootstrap.min.css",
                            "~/Scripts/Third-Party/DataTables/ColReorder-1.3.3/css/colReorder.bootstrap.min.css",
                            "~/Scripts/Third-Party/DataTables/Buttons-1.3.1/css/buttons.bootstrap.min.css",
                            "~/Scripts/Third-Party/DataTables/Select-1.2.2/css/select.bootstrap.min.css",
                            "~/Scripts/Third-Party/colorpicker/css/colorpicker.css"
                        ));
            var bundleHelper = new BundleHelper();
            bundleHelper.AddFromJson(bundles);
            Styles.DefaultTagFormat = bundleHelper.DefaultTagFormatForStyles;
            Scripts.DefaultTagFormat = bundleHelper.DefaultTagFormatForScripts;
        }
    }

    internal class NonOrderingBundleOrderer : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }
}