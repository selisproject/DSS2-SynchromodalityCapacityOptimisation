declare namespace Joove.Widgets {
    enum MenuVariant {
        NavBar = 0,
        SideNav = 1,
    }
    class MenuControl {
        private _menu;
        private _menuItems;
        private _menuWidth;
        private _menuItemWidth;
        private _menuVariant;
        private _ratio;
        private maxDrawTries;
        private static MAX_DRAW_TRIES;
        constructor(options: {
            menuVariant?: MenuVariant;
            ratio?: number;
        });
        Init(): void;
        private SaveMenuItems();
        private VisibleMenu(menu);
        private InitSideNav();
        static PreInit(): void;
        private InitNavBar();
        private CalculateMenuSize();
        private static ToogleSidenav(update?);
        private RegisterEventHandlers();
        private repositionSubmenu($subMenu, $parent);
        private HandleDraw();
        private Draw();
        private RecalculateMenuRatio(reset);
        private GetMenuItemSize(menuQuery);
        private ResetMenu(menuQuery, name);
        private HandleOverflowMenuItems(menuQuery, name, leftItemsToShow);
        private MarkEmptySubMenus();
        private HideEmptySubMenus();
        private GetChildMenu($menuItem);
        private _responsiveTimeout;
        private MakeMenusResponsive();
        private AdjustDimensions($menu);
        private static GetJbOverflowMenuItem(name);
    }
}
