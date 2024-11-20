using Syncfusion.Maui.DataGrid;
using System.Globalization;

namespace SampleLinebreakMode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
    }

    //public class PullToRefreshTemplateBehavior : Behavior<ContentPage>
    //{
    //    private ViewModel? viewModel;
    //    private Syncfusion.Maui.PullToRefresh.SfPullToRefresh? pullToRefresh;
    //    protected override void OnAttachedTo(ContentPage bindable)
    //    {
    //        this.viewModel = new ViewModel();
    //        bindable.BindingContext = this.viewModel;
    //        this.pullToRefresh = bindable.FindByName<Syncfusion.Maui.PullToRefresh.SfPullToRefresh>("pullToRefresh");
    //        this.pullToRefresh.Refreshing += this.PullToRefresh_Refreshing;
    //        base.OnAttachedTo(bindable);
    //    }

    //    private async void PullToRefresh_Refreshing(object? sender, EventArgs e)
    //    {
    //        this.pullToRefresh!.IsRefreshing = true;
    //        await Task.Delay(new TimeSpan(0, 0, 3));
    //        this.viewModel!.ItemsSourceRefresh();
    //        this.pullToRefresh.IsRefreshing = false;
    //    }

    //    protected override void OnDetachingFrom(ContentPage bindable)
    //    {
    //        this.pullToRefresh!.Refreshing -= this.PullToRefresh_Refreshing;
    //        base.OnDetachingFrom(bindable);
    //    }
    //}
}