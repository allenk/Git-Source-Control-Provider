namespace GitScc
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidSccProviderPkgString = "c4128d99-2000-41d1-a6c3-704e6c1a3de2";
        public const string guidSccProviderCmdSetString = "c4a089da-e640-438d-a977-815c267ca76d";
        public const string guidSccProviderImagesString = "495089fd-a8ca-4260-8eb1-794e2956b625";
        public const string guidSccProviderImageSwitchString = "d29bf411-deac-4a50-8d84-389de40da2d4";
        public const string guidSccProviderImageHistoryString = "2544ac47-1ddf-41ef-8fd9-c1fcfaf16e7c";
        public const string guidSccProviderImageRefreshString = "254c6918-2499-415f-bd52-5da291333808";
        public const string guidSccProviderImagePendingCheckinsString = "8e7c0075-060a-4411-a90c-be88e4370386";
        public const string guidSccProviderImageCompareString = "89c2ce10-4265-462c-83b6-bec12cf0cdd0";
        public const string guidSccProviderImageUndoCheckoutString = "78b4aed4-1fec-4910-a3f7-8fe4022bed8b";
        public static Guid guidSccProviderPkg = new Guid(guidSccProviderPkgString);
        public static Guid guidSccProviderCmdSet = new Guid(guidSccProviderCmdSetString);
        public static Guid guidSccProviderImages = new Guid(guidSccProviderImagesString);
        public static Guid guidSccProviderImageSwitch = new Guid(guidSccProviderImageSwitchString);
        public static Guid guidSccProviderImageHistory = new Guid(guidSccProviderImageHistoryString);
        public static Guid guidSccProviderImageRefresh = new Guid(guidSccProviderImageRefreshString);
        public static Guid guidSccProviderImagePendingCheckins = new Guid(guidSccProviderImagePendingCheckinsString);
        public static Guid guidSccProviderImageCompare = new Guid(guidSccProviderImageCompareString);
        public static Guid guidSccProviderImageUndoCheckout = new Guid(guidSccProviderImageUndoCheckoutString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int icmdSccCommandRefresh = 0x0101;
        public const int icmdSccCommandGitBash = 0x0102;
        public const int icmdSccCommandGitExtension = 0x0103;
        public const int icmdSccCommandCompare = 0x0104;
        public const int icmdSccCommandUndo = 0x0105;
        public const int icmdSccCommandInit = 0x0106;
        public const int icmdSccCommandPendingChanges = 0x0107;
        public const int icmdSccCommandHistory = 0x0108;
        public const int icmdSccCommandGitTortoise = 0x0109;
        public const int icmdSccCommandEditIgnore = 0x0110;
        public const int imnuGitSourceControlMenu = 0x0205;
        public const int igrpSourceControlCommands = 0x0301;
        public const int igrpDocTabWnd = 0x0302;
        public const int imnuHistoryToolWindowToolbarMenu = 0x0200;
        public const int igrpHistoryToolWindowToolbarGroup = 0x0201;
        public const int imnuPendingChangesToolWindowToolbarMenu = 0x0202;
        public const int igrpPendingChangesToolWindowToolbarGroup = 0x0203;
        public const int icmdPendingChangesCommit = 0x0111;
        public const int icmdPendingChangesAmend = 0x0112;
        public const int icmdPendingChangesCommitToBranch = 0x0113;
        public const int icmdPendingChangesRefresh = 0x0114;
        public const int icmdHistoryViewRefresh = 0x0115;
        public const int icmdPendingChangesSettings = 0x0116;
        public const int icmdGitIgnoreSubMenuCommandOpen = 0x2015;
        public const int icmdGitIgnoreSubMenuCommandUpdate = 0x2016;
        public const int igrpGeneralSourceControlCommands = 0x0700;
        public const int imnuGeneralSourceControlCommands = 0x0701;
        public const int igrpGitExtCommands = 0x0800;
        public const int imnuGitExtMenu = 0x0801;
        public const int igrpGitTorCommands = 0x0900;
        public const int imnuGitTorMenu = 0x0901;
        public const int imnuGitIgnoreMenu = 0x2001;
        public const int icmdGitExtCommand1 = 0x0811;
        public const int icmdGitTorCommand1 = 0x0911;
        public const int icmdGitIgnoreCommand1 = 0x2011;
        public const int imnuPendingChangesToolWindowGitExt = 0x0951;
        public const int igrpPendingChangesToolWindowGitExt = 0x0952;
        public const int imnuPendingChangesToolWindowGitTor = 0x0961;
        public const int igrpPendingChangesToolWindowGitTor = 0x0962;
        public const int BranchMenu = 0x1000;
        public const int BranchGroup = 0x2000;
        public const int BranchCommandGroup = 0x2100;
        public const int cmdidBranchMenuCommandAnchor = 0x3000;
        public const int cmdidBranchMenuCommandStart = 0x3001;
        public const int cmdidBranchMenuStartAnchor = 0x3100;
        public const int cmdidBranchmenuStart = 0x3101;
        public const int GitIgnoreSubMenu = 0x1100;
        public const int GitIgnoreSubMenuGroup = 0x1150;
        public const int iconGitBash = 0x0001;
        public const int iconGitExt = 0x0002;
        public const int iconUncheckout = 0x0003;
        public const int iconCompare = 0x0004;
        public const int iconRefresh = 0x0005;
        public const int iconOpenIgnoreFile = 0x0006;
        public const int iconGitTor = 0x0007;
        public const int iconGitInit = 0x0008;
    }
}
