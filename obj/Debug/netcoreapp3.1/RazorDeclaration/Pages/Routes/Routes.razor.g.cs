// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blalogin.Pages.Routes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\SrikantSir\KT\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SrikantSir\KT\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SrikantSir\KT\_Imports.razor"
using blalogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SrikantSir\KT\_Imports.razor"
using blalogin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SrikantSir\KT\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SrikantSir\KT\Pages\Routes\Routes.razor"
using blalogin.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SrikantSir\KT\Pages\Routes\Routes.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SrikantSir\KT\Pages\Routes\Routes.razor"
using ExcelDataReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SrikantSir\KT\Pages\Routes\Routes.razor"
using Syncfusion.XlsIO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SrikantSir\KT\Pages\Routes\Routes.razor"
using Syncfusion.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SrikantSir\KT\Pages\Routes\Routes.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Routes/Routes")]
    public partial class Routes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\SrikantSir\KT\Pages\Routes\Routes.razor"
       

    List<Route> RObj;

    public int CurrentPage { get; set; } = 1;
    public int Count { get; set; }
    public int PageSize { get; set; } = 10;
    public int TotalPages { get; set; } = 1;
    int startPage = 1;
    int endPage = 4;
    bool Islastpageload = false;
    bool IsfirstPageload = true;
    bool loading = false;

    public bool ShowPrevious => CurrentPage > 1;
    public bool ShowNext => CurrentPage < TotalPages;

    protected override async Task OnInitializedAsync()
    {
        RObj = await GetAllRoute();
        Count = await Task.Run(() => routeService.GetCountAsync());
        TotalPages = (int)Math.Ceiling(decimal.Divide(Count, PageSize));
    }
    async Task pageClick(int i)
    {
        if (loading == false)
        {
            loading = true;
            CurrentPage = i;
            if (endPage > 4)
            {
                IsfirstPageload = false;
            }
            if (startPage == 1)
            {
                IsfirstPageload = true;
            }
            RObj = await GetAllRoute();
            this.StateHasChanged();
        }
    }

    async Task loadNextfourpage(int i)
    {
        CurrentPage = i;
        if (CurrentPage > TotalPages)
        {
            CurrentPage = TotalPages;
        }

        if (endPage < TotalPages)
        {
            int _lastpage = 0;
            Islastpageload = false;
            if (CurrentPage >= endPage)
            {
                startPage = endPage + 1;
                _lastpage = startPage + 4;
                endPage = _lastpage >= TotalPages ? TotalPages : _lastpage;
            }
        }
        else
        {
            endPage = TotalPages;
            Islastpageload = true;
        }
        await pageClick(CurrentPage);
        // RObj = await GetAllRoute();
    }

    async Task loadpriviousfourpage(int i)
    {
        CurrentPage = i;
        if (CurrentPage <= 0)
        {
            CurrentPage = startPage;
        }
        int _fpage = 0;

        _fpage = CurrentPage - 4;
        if (_fpage > 0)
        {
            startPage = _fpage;
            endPage = startPage + 4;
            IsfirstPageload = false;
        }
        else
        {
            startPage = 1;
            endPage = 4;
        }
        await pageClick(CurrentPage);
        // RObj = await GetAllRoute();
    }
    public async Task<List<Route>> GetAllRoute()
    {
        var r = await Task.Run(() => routeService.GetAllRoutesAsync(CurrentPage, PageSize));
        RObj = r;
        loading = false;
        return r;
    }
    private string searchTerm;
    private List<Route> issues;
    async Task SearchIssues()
    {
        RObj = await routeService.SearchIssuesAsync(searchTerm);
    }
    private async Task Clear()
    {
        searchTerm = string.Empty;
        await SearchIssues();
    }
    string status;
    async Task HandleSelection(IFileListEntry[] files)
    {
        loading = true;
        List<Route> routs = new List<Route>();
        var file = files.FirstOrDefault();
        if (file != null)
        {
            // Just load into .NET memory to show it can be done
            // Alternatively it could be saved to disk, or parsed in memory, or similar
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            status = $"Finished loading {file.Size} bytes from {file.Name}";
            routs = new List<Route>();
            using (var reader = ExcelReaderFactory.CreateReader(ms))
            {
                int i = 0;
                while (reader.Read()) //Each row of the file
                {
                    if (i == 0)
                    {
                        i = 1;
                    }
                    else
                    {
                        routs.Add(new Route
                        {
                            // Id = Convert.ToInt32(reader.GetValue(0)),
                            Routename = reader.GetValue(0).ToString(),
                            Supervisorname = reader.GetValue(1).ToString(),
                            Billdays = Convert.ToInt32(reader.GetValue(2)),
                            Code = Convert.ToInt32(reader.GetValue(3))
                        });
                    }
                }
            }
            await SaveRoute(routs);
        }
    }

    async Task SaveRoute(List<Route> routes)
    {
        await routeService.SaveRoutes(routes);
        await GetAllRoute();
        loading = false;
        status = $"File Save Successfully in database";
    }

    async Task ExportToExcel()
    {
        using (ExcelEngine excelEngine = new ExcelEngine())
        {
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Xlsx;

            //Create a workbook.
            IWorkbook workbook = application.Workbooks.Create(1);
            IWorksheet worksheet = workbook.Worksheets[0];

            //Initialize DataTable and data get from SampleDataTable method.
            DataTable table = SampleDataTable();

            //Export data from DataTable to Excel worksheet.
            worksheet.ImportDataTable(table, true, 1, 1);

            worksheet.UsedRange.AutofitColumns();


            //Save the document as a stream and return the stream.
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Excel document to MemoryStream
                workbook.SaveAs(stream);

                //Download the excel file.
                //await JS.SaveAs("Sample.xlsx", stream.ToArray());
            }
        }


    }
    private DataTable SampleDataTable()
    {
        DataTable reports = new DataTable();
        reports.Columns.Add("SalesPerson");
        reports.Columns.Add("Age", typeof(int));
        reports.Columns.Add("Salary", typeof(int));
        reports.Rows.Add("Andy Bernard", 21, 30000);
        reports.Rows.Add("Jim Halpert", 25, 40000);
        reports.Rows.Add("Karen Fillippelli", 30, 50000);
        reports.Rows.Add("Phyllis Lapin", 34, 39000);
        reports.Rows.Add("Stanley Hudson", 45, 58000);

        return reports;
    }

    public async Task NavigateToPage(string direction)
    {
        if (direction == "next")
        {
            if (CurrentPage < TotalPages)
            {
                if (CurrentPage == startPage)
                {
                    SetPagerSize("forward");
                }
                CurrentPage += 1;
            }
            await loadNextfourpage(CurrentPage);
        }
        else if (direction == "previous")
        {
            if (CurrentPage > 1)
            {
                if (CurrentPage == startPage)
                {
                    SetPagerSize("back");
                }
                CurrentPage -= 1;
            }
            await loadpriviousfourpage(CurrentPage);
        }
        // await pageClick(CurrentPage);
    }

    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < TotalPages)
        {
            startPage = endPage + 1;
            if (endPage + PageSize < TotalPages)
            {
                endPage = startPage + PageSize - 1;
            }
            else
            {
                endPage = TotalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - PageSize;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RouteService routeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
