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

namespace Calculator_testing
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TestSummNuNu recording.
    /// </summary>
    [TestModule("830eba56-c67e-4d47-8a4b-827bd95dc47a", ModuleType.Recording, 1)]
    public partial class TestSummNuNu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Calculator_testingRepository repository.
        /// </summary>
        public static Calculator_testingRepository repo = Calculator_testingRepository.Instance;

        static TestSummNuNu instance = new TestSummNuNu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TestSummNuNu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TestSummNuNu Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Калькулятор.SomeContainer.Button3' at Center.", repo.Калькулятор.SomeContainer.Button3Info, new RecordItemIndex(0));
            repo.Калькулятор.SomeContainer.Button3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Калькулятор.SomeContainer.ButtonPlus1' at Center.", repo.Калькулятор.SomeContainer.ButtonPlus1Info, new RecordItemIndex(1));
            repo.Калькулятор.SomeContainer.ButtonPlus1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Калькулятор.SomeContainer.ButtonPlus' at Center.", repo.Калькулятор.SomeContainer.ButtonPlusInfo, new RecordItemIndex(2));
            repo.Калькулятор.SomeContainer.ButtonPlus.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Калькулятор.SomeContainer.Button9' at Center.", repo.Калькулятор.SomeContainer.Button9Info, new RecordItemIndex(3));
            repo.Калькулятор.SomeContainer.Button9.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Калькулятор.SomeContainer.ButtonPlus1' at Center.", repo.Калькулятор.SomeContainer.ButtonPlus1Info, new RecordItemIndex(4));
            repo.Калькулятор.SomeContainer.ButtonPlus1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Калькулятор.SomeContainer.ButtonEq' at Center.", repo.Калькулятор.SomeContainer.ButtonEqInfo, new RecordItemIndex(5));
            repo.Калькулятор.SomeContainer.ButtonEq.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
