﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace Phoenix_Project.Tests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinClient uIChromeLegacyWindowClient = this.UIMalhotrasCuisineGoogWindow.UIChromeLegacyWindowWindow.UIChromeLegacyWindowClient;
            WinControl uIItemDocument = this.UIMalhotrasCuisineGoogWindow.UIMalhotrasCuisineGoogClient.UIItemDocument;
            WinControl uIChromeLegacyWindowDocument = this.UIMalhotrasCuisineGoogWindow.UIMalhotrasCuisineGoogClient.UIChromeLegacyWindowDocument;
            #endregion

            // Click 'Chrome Legacy Window' client
            Mouse.Click(uIChromeLegacyWindowClient, new Point(1067, 20));

            // Click 'Chrome Legacy Window' client
            Mouse.Click(uIChromeLegacyWindowClient, new Point(499, 307));

            // Type 'sing1231' in document
            Keyboard.SendKeys(uIItemDocument, this.RecordedMethod1Params.UIItemDocumentSendKeys, ModifierKeys.None);

            // Click 'Chrome Legacy Window' document
            Mouse.Click(uIChromeLegacyWindowDocument, new Point(494, 345));

            // Click 'Chrome Legacy Window' document
            Mouse.Click(uIChromeLegacyWindowDocument, new Point(494, 339));

            // Type '123456' in document
            Keyboard.SendKeys(uIItemDocument, this.RecordedMethod1Params.UIItemDocumentSendKeys1, ModifierKeys.None);

            // Click 'Chrome Legacy Window' document
            Mouse.Click(uIChromeLegacyWindowDocument, new Point(562, 349));

            // Click 'Chrome Legacy Window' document
            Mouse.Click(uIChromeLegacyWindowDocument, new Point(415, 364));
        }
        
        /// <summary>
        /// AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            WinEdit uIAddressandsearchbarEdit = this.UIMalhotrasCuisineGoogWindow.UIAddressandsearchbarGroup.UIAddressandsearchbarEdit;
            #endregion

            // Verify that the 'Text' property of 'Address and search bar' text box matches 'localhost:56568'
            StringAssert.Matches(uIAddressandsearchbarEdit.Text, new Regex(this.AssertMethod1ExpectedValues.UIAddressandsearchbarEditText));

            // Verify that the 'Text' property of 'Address and search bar' text box equals 'localhost:56568'
            Assert.AreEqual(this.AssertMethod1ExpectedValues.UIAddressandsearchbarEditText1, uIAddressandsearchbarEdit.Text, "are not equal");
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }
        
        public UIMalhotrasCuisineGoogWindow UIMalhotrasCuisineGoogWindow
        {
            get
            {
                if ((this.mUIMalhotrasCuisineGoogWindow == null))
                {
                    this.mUIMalhotrasCuisineGoogWindow = new UIMalhotrasCuisineGoogWindow();
                }
                return this.mUIMalhotrasCuisineGoogWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
        
        private UIMalhotrasCuisineGoogWindow mUIMalhotrasCuisineGoogWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Type 'sing1231' in document
        /// </summary>
        public string UIItemDocumentSendKeys = "sing1231";
        
        /// <summary>
        /// Type '123456' in document
        /// </summary>
        public string UIItemDocumentSendKeys1 = "123456";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class AssertMethod1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Text' property of 'Address and search bar' text box matches 'localhost:56568'
        /// </summary>
        public string UIAddressandsearchbarEditText = "localhost:56568";
        
        /// <summary>
        /// Verify that the 'Text' property of 'Address and search bar' text box equals 'localhost:56568'
        /// </summary>
        public string UIAddressandsearchbarEditText1 = "localhost:56568";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIMalhotrasCuisineGoogWindow : WinWindow
    {
        
        public UIMalhotrasCuisineGoogWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Malhotra\'s Cuisine - Google Chrome";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Chrome_WidgetWin_0";
            this.WindowTitles.Add("Malhotra\'s Cuisine - Google Chrome");
            #endregion
        }
        
        #region Properties
        public UIChromeLegacyWindowWindow UIChromeLegacyWindowWindow
        {
            get
            {
                if ((this.mUIChromeLegacyWindowWindow == null))
                {
                    this.mUIChromeLegacyWindowWindow = new UIChromeLegacyWindowWindow(this);
                }
                return this.mUIChromeLegacyWindowWindow;
            }
        }
        
        public UIMalhotrasCuisineGoogClient UIMalhotrasCuisineGoogClient
        {
            get
            {
                if ((this.mUIMalhotrasCuisineGoogClient == null))
                {
                    this.mUIMalhotrasCuisineGoogClient = new UIMalhotrasCuisineGoogClient(this);
                }
                return this.mUIMalhotrasCuisineGoogClient;
            }
        }
        
        public UIAddressandsearchbarGroup UIAddressandsearchbarGroup
        {
            get
            {
                if ((this.mUIAddressandsearchbarGroup == null))
                {
                    this.mUIAddressandsearchbarGroup = new UIAddressandsearchbarGroup(this);
                }
                return this.mUIAddressandsearchbarGroup;
            }
        }
        #endregion
        
        #region Fields
        private UIChromeLegacyWindowWindow mUIChromeLegacyWindowWindow;
        
        private UIMalhotrasCuisineGoogClient mUIMalhotrasCuisineGoogClient;
        
        private UIAddressandsearchbarGroup mUIAddressandsearchbarGroup;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIChromeLegacyWindowWindow : WinWindow
    {
        
        public UIChromeLegacyWindowWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "181110528";
            this.WindowTitles.Add("Malhotra\'s Cuisine - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinClient UIChromeLegacyWindowClient
        {
            get
            {
                if ((this.mUIChromeLegacyWindowClient == null))
                {
                    this.mUIChromeLegacyWindowClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIChromeLegacyWindowClient.SearchProperties[WinControl.PropertyNames.Name] = "Chrome Legacy Window";
                    this.mUIChromeLegacyWindowClient.WindowTitles.Add("Malhotra\'s Cuisine - Google Chrome");
                    #endregion
                }
                return this.mUIChromeLegacyWindowClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIChromeLegacyWindowClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIMalhotrasCuisineGoogClient : WinClient
    {
        
        public UIMalhotrasCuisineGoogClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Malhotra\'s Cuisine - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinControl UIItemDocument
        {
            get
            {
                if ((this.mUIItemDocument == null))
                {
                    this.mUIItemDocument = new WinControl(this);
                    #region Search Criteria
                    this.mUIItemDocument.SearchProperties[UITestControl.PropertyNames.ControlType] = "Document";
                    this.mUIItemDocument.WindowTitles.Add("Malhotra\'s Cuisine - Google Chrome");
                    #endregion
                }
                return this.mUIItemDocument;
            }
        }
        
        public WinControl UIChromeLegacyWindowDocument
        {
            get
            {
                if ((this.mUIChromeLegacyWindowDocument == null))
                {
                    this.mUIChromeLegacyWindowDocument = new WinControl(this);
                    #region Search Criteria
                    this.mUIChromeLegacyWindowDocument.SearchProperties[UITestControl.PropertyNames.ControlType] = "Document";
                    this.mUIChromeLegacyWindowDocument.WindowTitles.Add("Malhotra\'s Cuisine - Google Chrome");
                    #endregion
                }
                return this.mUIChromeLegacyWindowDocument;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUIItemDocument;
        
        private WinControl mUIChromeLegacyWindowDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIAddressandsearchbarGroup : WinGroup
    {
        
        public UIAddressandsearchbarGroup(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Address and search bar";
            this.WindowTitles.Add("Malhotra\'s Cuisine - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinEdit UIAddressandsearchbarEdit
        {
            get
            {
                if ((this.mUIAddressandsearchbarEdit == null))
                {
                    this.mUIAddressandsearchbarEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIAddressandsearchbarEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Address and search bar";
                    this.mUIAddressandsearchbarEdit.WindowTitles.Add("Malhotra\'s Cuisine - Google Chrome");
                    #endregion
                }
                return this.mUIAddressandsearchbarEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIAddressandsearchbarEdit;
        #endregion
    }
}
