// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace RunningApp {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("/Users/balbi/Projects/RunningApp/RunningApp/Pages/MyHistoryPage.xaml")]
    public partial class MyHistoryPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label kilometer_label;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label heartRate_label;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label calories_label;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ListView RoutesView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MyHistoryPage));
            kilometer_label = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Label>(this, "kilometer_label");
            heartRate_label = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Label>(this, "heartRate_label");
            calories_label = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Label>(this, "calories_label");
            RoutesView = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.ListView>(this, "RoutesView");
        }
    }
}
