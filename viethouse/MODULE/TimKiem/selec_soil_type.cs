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

namespace viethouse.MODULE.TimKiem
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The selec_soil_type recording.
    /// </summary>
    [TestModule("555e3ea0-9237-479a-a2b2-5f1257ae4068", ModuleType.Recording, 1)]
    public partial class selec_soil_type : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::viethouse.viethouseRepository repository.
        /// </summary>
        public static global::viethouse.viethouseRepository repo = global::viethouse.viethouseRepository.Instance;

        static selec_soil_type instance = new selec_soil_type();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public selec_soil_type()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static selec_soil_type Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable itemSoilType.
        /// </summary>
        [TestVariable("95119461-757d-4f9e-a9a6-38b051d9100d")]
        public string itemSoilType
        {
            get { return repo.itemSoilType; }
            set { repo.itemSoilType = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TimKiem.spinSoilType' at 187;23.", repo.TimKiem.spinSoilTypeInfo, new RecordItemIndex(0));
            repo.TimKiem.spinSoilType.Click("187;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TimKiem.itemSoilType' at 258;12.", repo.TimKiem.itemSoilTypeInfo, new RecordItemIndex(1));
            repo.TimKiem.itemSoilType.Click("258;12");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}