///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace viethouse.MODULE.CapNhatThongTin.GioiTinh
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Khac recording.
    /// </summary>
    [TestModule("8961edc5-72f1-4587-8f3e-91911d1b786d", ModuleType.Recording, 1)]
    public partial class Khac : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::viethouse.viethouseRepository repository.
        /// </summary>
        public static global::viethouse.viethouseRepository repo = global::viethouse.viethouseRepository.Instance;

        static Khac instance = new Khac();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Khac()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Khac Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản2.Checkmark2' at 20;8.", repo.ThongTinTaiKhoản2.Checkmark2Info, new RecordItemIndex(0));
            repo.ThongTinTaiKhoản2.Checkmark2.Click("20;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản2.ChangeInfo' at 127;27.", repo.ThongTinTaiKhoản2.ChangeInfoInfo, new RecordItemIndex(1));
            repo.ThongTinTaiKhoản2.ChangeInfo.Click("127;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ThongTinTaiKhoản2.CậpNhậtThongTinTaiKhoảnThanhCong'.", repo.ThongTinTaiKhoản2.CậpNhậtThongTinTaiKhoảnThanhCongInfo, new RecordItemIndex(2));
            Validate.Exists(repo.ThongTinTaiKhoản2.CậpNhậtThongTinTaiKhoảnThanhCongInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoảnGoogleChrome.TảiLại' at 19;23.", repo.ThongTinTaiKhoảnGoogleChrome.TảiLạiInfo, new RecordItemIndex(3));
            repo.ThongTinTaiKhoảnGoogleChrome.TảiLại.Click("19;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ThongTinTaiKhoản2.LabelTagKhac'.", repo.ThongTinTaiKhoản2.LabelTagKhacInfo, new RecordItemIndex(4));
            Validate.Exists(repo.ThongTinTaiKhoản2.LabelTagKhacInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
