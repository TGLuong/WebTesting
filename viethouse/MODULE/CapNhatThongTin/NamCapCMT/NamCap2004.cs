﻿///////////////////////////////////////////////////////////////////////////////
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

namespace viethouse.MODULE.CapNhatThongTin.NamCapCMT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The NamCap2004 recording.
    /// </summary>
    [TestModule("d6066378-f5ba-4fe4-b307-445bf56361cf", ModuleType.Recording, 1)]
    public partial class NamCap2004 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::viethouse.viethouseRepository repository.
        /// </summary>
        public static global::viethouse.viethouseRepository repo = global::viethouse.viethouseRepository.Instance;

        static NamCap2004 instance = new NamCap2004();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NamCap2004()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NamCap2004 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản2.ProfileIssueDate' at 142;20.", repo.ThongTinTaiKhoản2.ProfileIssueDateInfo, new RecordItemIndex(0));
            repo.ThongTinTaiKhoản2.ProfileIssueDate.Click("142;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ThongTinTaiKhoản2.ProfileIssueDate'.", repo.ThongTinTaiKhoản2.ProfileIssueDateInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.ThongTinTaiKhoản2.ProfileIssueDate);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}1' with focus on 'ThongTinTaiKhoản2.ProfileIssueDate'.", repo.ThongTinTaiKhoản2.ProfileIssueDateInfo, new RecordItemIndex(2));
            repo.ThongTinTaiKhoản2.ProfileIssueDate.PressKeys("{Back}1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '/1/2004' with focus on 'ThongTinTaiKhoản2.ProfileIssueDate'.", repo.ThongTinTaiKhoản2.ProfileIssueDateInfo, new RecordItemIndex(3));
            repo.ThongTinTaiKhoản2.ProfileIssueDate.PressKeys("/1/2004");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản2.ChangeInfo' at 91;33.", repo.ThongTinTaiKhoản2.ChangeInfoInfo, new RecordItemIndex(4));
            repo.ThongTinTaiKhoản2.ChangeInfo.Click("91;33");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'ThongTinTaiKhoản2.CậpNhậtThongTinTaiKhoảnThanhCong'.", repo.ThongTinTaiKhoản2.CậpNhậtThongTinTaiKhoảnThanhCongInfo, new RecordItemIndex(5));
            Validate.NotExists(repo.ThongTinTaiKhoản2.CậpNhậtThongTinTaiKhoảnThanhCongInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
