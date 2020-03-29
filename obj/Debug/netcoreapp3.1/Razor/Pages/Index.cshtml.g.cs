#pragma checksum "C:\ASPNetProject\dashboard-admin-asp-dot-net\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dd55210082168f9cf80a2cff190cde71ab9865d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dashboard_admin_asp_dot_net.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace dashboard_admin_asp_dot_net.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\ASPNetProject\dashboard-admin-asp-dot-net\Pages\_ViewImports.cshtml"
using dashboard_admin_asp_dot_net;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dd55210082168f9cf80a2cff190cde71ab9865d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00900d84580d41b48ee2b6f72b7a62b690fb0c20", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\ASPNetProject\dashboard-admin-asp-dot-net\Pages\Index.cshtml"
  
ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""content"">
	<div class=""row"">
		<div class=""col-12"">
			<div class=""card card-chart"">
				<div class=""card-header "">
					<div class=""row"">
						<div class=""col-sm-6 text-left"">
							<h5 class=""card-category"">Total Shipments</h5>
							<h2 class=""card-title"">Performance</h2>
						</div>
						<div class=""col-sm-6"">
							<div class=""btn-group btn-group-toggle float-right"" data-toggle=""buttons"">
								<label class=""btn btn-sm btn-primary btn-simple active"" id=""0"">
									<input type=""radio"" name=""options"" checked>
									<span class=""d-none d-sm-block d-md-block d-lg-block d-xl-block"">Accounts</span>
									<span class=""d-block d-sm-none"">
										<i class=""tim-icons icon-single-02""></i>
									</span>
								</label>
								<label class=""btn btn-sm btn-primary btn-simple"" id=""1"">
									<input type=""radio"" class=""d-none d-sm-none"" name=""options"">
									<span class=""d-none d-sm-block d-md-block d-lg-block d-xl-block"">Purchases</span>
									<span clas");
            WriteLiteral(@"s=""d-block d-sm-none"">
										<i class=""tim-icons icon-gift-2""></i>
									</span>
								</label>
								<label class=""btn btn-sm btn-primary btn-simple"" id=""2"">
									<input type=""radio"" class=""d-none"" name=""options"">
									<span class=""d-none d-sm-block d-md-block d-lg-block d-xl-block"">Sessions</span>
									<span class=""d-block d-sm-none"">
										<i class=""tim-icons icon-tap-02""></i>
									</span>
								</label>
							</div>
						</div>
					</div>
				</div>
				<div class=""card-body"">
					<div class=""chart-area"">
						<canvas id=""chartBig1""></canvas>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""row"">
		<div class=""col-lg-4"">
			<div class=""card card-chart"">
				<div class=""card-header"">
					<h5 class=""card-category"">Total Shipments</h5>
					<h3 class=""card-title""><i class=""tim-icons icon-bell-55 text-primary""></i> 763,215</h3>
				</div>
				<div class=""card-body"">
					<div class=""chart-area"">
						<canvas id=""chartLinePur");
            WriteLiteral(@"ple""></canvas>
					</div>
				</div>
			</div>
		</div>
		<div class=""col-lg-4"">
			<div class=""card card-chart"">
				<div class=""card-header"">
					<h5 class=""card-category"">Daily Sales</h5>
					<h3 class=""card-title""><i class=""tim-icons icon-delivery-fast text-info""></i> 3,500€</h3>
				</div>
				<div class=""card-body"">
					<div class=""chart-area"">
						<canvas id=""CountryChart""></canvas>
					</div>
				</div>
			</div>
		</div>
		<div class=""col-lg-4"">
			<div class=""card card-chart"">
				<div class=""card-header"">
					<h5 class=""card-category"">Completed Tasks</h5>
					<h3 class=""card-title""><i class=""tim-icons icon-send text-success""></i> 12,100K</h3>
				</div>
				<div class=""card-body"">
					<div class=""chart-area"">
						<canvas id=""chartLineGreen""></canvas>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""row"">
		<div class=""col-lg-6 col-md-12"">
			<div class=""card card-tasks"">
				<div class=""card-header "">
					<h6 class=""title d-inline"">Task");
            WriteLiteral(@"s(5)</h6>
					<p class=""card-category d-inline"">today</p>
					<div class=""dropdown"">
						<button type=""button"" class=""btn btn-link dropdown-toggle btn-icon"" data-toggle=""dropdown"">
							<i class=""tim-icons icon-settings-gear-63""></i>
						</button>
						<div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuLink"">
							<a class=""dropdown-item"" href=""#pablo"">Action</a>
							<a class=""dropdown-item"" href=""#pablo"">Another action</a>
							<a class=""dropdown-item"" href=""#pablo"">Something else</a>
						</div>
					</div>
				</div>
				<div class=""card-body "">
					<div class=""table-full-width table-responsive"">
						<table class=""table"">
							<tbody>
								<tr>
									<td>
										<div class=""form-check"">
											<label class=""form-check-label"">
												<input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 4046, "\"", 4054, 0);
            EndWriteAttribute();
            WriteLiteral(@">
												<span class=""form-check-sign"">
													<span class=""check""></span>
												</span>
											</label>
										</div>
									</td>
									<td>
										<p class=""title"">Update the Documentation</p>
										<p class=""text-muted"">Dwuamish Head, Seattle, WA 8:47 AM</p>
									</td>
									<td class=""td-actions text-right"">
										<button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 4470, "\"", 4478, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
											<i class=""tim-icons icon-pencil""></i>
										</button>
									</td>
								</tr>
								<tr>
									<td>
										<div class=""form-check"">
											<label class=""form-check-label"">
												<input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 4806, "\"", 4814, 0);
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 4815, "\"", 4825, 0);
            EndWriteAttribute();
            WriteLiteral(@">
												<span class=""form-check-sign"">
													<span class=""check""></span>
												</span>
											</label>
										</div>
									</td>
									<td>
										<p class=""title"">GDPR Compliance</p>
										<p class=""text-muted"">The GDPR is a regulation that requires businesses to protect the
											personal data and privacy of Europe citizens for transactions that occur within EU member
											states.</p>
									</td>
									<td class=""td-actions text-right"">
										<button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 5384, "\"", 5392, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
											<i class=""tim-icons icon-pencil""></i>
										</button>
									</td>
								</tr>
								<tr>
									<td>
										<div class=""form-check"">
											<label class=""form-check-label"">
												<input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 5720, "\"", 5728, 0);
            EndWriteAttribute();
            WriteLiteral(@">
												<span class=""form-check-sign"">
													<span class=""check""></span>
												</span>
											</label>
										</div>
									</td>
									<td>
										<p class=""title"">Solve the issues</p>
										<p class=""text-muted"">Fifty percent of all respondents said they would be more likely to shop
											at a company </p>
									</td>
									<td class=""td-actions text-right"">
										<button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 6199, "\"", 6207, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
											<i class=""tim-icons icon-pencil""></i>
										</button>
									</td>
								</tr>
								<tr>
									<td>
										<div class=""form-check"">
											<label class=""form-check-label"">
												<input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 6535, "\"", 6543, 0);
            EndWriteAttribute();
            WriteLiteral(@">
												<span class=""form-check-sign"">
													<span class=""check""></span>
												</span>
											</label>
										</div>
									</td>
									<td>
										<p class=""title"">Release v2.0.0</p>
										<p class=""text-muted"">Ra Ave SW, Seattle, WA 98116, SUA 11:19 AM</p>
									</td>
									<td class=""td-actions text-right"">
										<button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 6957, "\"", 6965, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
											<i class=""tim-icons icon-pencil""></i>
										</button>
									</td>
								</tr>
								<tr>
									<td>
										<div class=""form-check"">
											<label class=""form-check-label"">
												<input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 7293, "\"", 7301, 0);
            EndWriteAttribute();
            WriteLiteral(@">
												<span class=""form-check-sign"">
													<span class=""check""></span>
												</span>
											</label>
										</div>
									</td>
									<td>
										<p class=""title"">Export the processed files</p>
										<p class=""text-muted"">The report also shows that consumers will not easily forgive a company
											once a breach exposing their personal data occurs. </p>
									</td>
									<td class=""td-actions text-right"">
										<button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 7819, "\"", 7827, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
											<i class=""tim-icons icon-pencil""></i>
										</button>
									</td>
								</tr>
								<tr>
									<td>
										<div class=""form-check"">
											<label class=""form-check-label"">
												<input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 8155, "\"", 8163, 0);
            EndWriteAttribute();
            WriteLiteral(@">
												<span class=""form-check-sign"">
													<span class=""check""></span>
												</span>
											</label>
										</div>
									</td>
									<td>
										<p class=""title"">Arival at export process</p>
										<p class=""text-muted"">Capitol Hill, Seattle, WA 12:34 AM</p>
									</td>
									<td class=""td-actions text-right"">
										<button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 8579, "\"", 8587, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
											<i class=""tim-icons icon-pencil""></i>
										</button>
									</td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>
			</div>
		</div>
		<div class=""col-lg-6 col-md-12"">
			<div class=""card "">
				<div class=""card-header"">
					<h4 class=""card-title""> Simple Table</h4>
				</div>
				<div class=""card-body"">
					<div class=""table-responsive"">
						<table class=""table tablesorter """);
            BeginWriteAttribute("id", " id=\"", 9081, "\"", 9086, 0);
            EndWriteAttribute();
            WriteLiteral(@">
							<thead class="" text-primary"">
								<tr>
									<th>
										Name
									</th>
									<th>
										Country
									</th>
									<th>
										City
									</th>
									<th class=""text-center"">
										Salary
									</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td>
										Dakota Rice
									</td>
									<td>
										Niger
									</td>
									<td>
										Oud-Turnhout
									</td>
									<td class=""text-center"">
										$36,738
									</td>
								</tr>
								<tr>
									<td>
										Minerva Hooper
									</td>
									<td>
										Curaçao
									</td>
									<td>
										Sinaai-Waas
									</td>
									<td class=""text-center"">
										$23,789
									</td>
								</tr>
								<tr>
									<td>
										Sage Rodriguez
									</td>
									<td>
										Netherlands
									</td>
									<td>
										Baileux
									</td>
									<td clas");
            WriteLiteral(@"s=""text-center"">
										$56,142
									</td>
								</tr>
								<tr>
									<td>
										Philip Chaney
									</td>
									<td>
										Korea, South
									</td>
									<td>
										Overland Park
									</td>
									<td class=""text-center"">
										$38,735
									</td>
								</tr>
								<tr>
									<td>
										Doris Greene
									</td>
									<td>
										Malawi
									</td>
									<td>
										Feldkirchen in Kärnten
									</td>
									<td class=""text-center"">
										$63,542
									</td>
								</tr>
								<tr>
									<td>
										Mason Porter
									</td>
									<td>
										Chile
									</td>
									<td>
										Gloucester
									</td>
									<td class=""text-center"">
										$78,615
									</td>
								</tr>
								<tr>
									<td>
										Jon Porter
									</td>
									<td>
										Portugal
									</td>
									<td>
										Gloucester
									</t");
            WriteLiteral("d>\r\n\t\t\t\t\t\t\t\t\t<td class=\"text-center\">\r\n\t\t\t\t\t\t\t\t\t\t$98,615\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
