#pragma checksum "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Store\ProductAdidas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a3877bdde7cac57f8990004e8332ad97730c009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_ProductAdidas), @"mvc.1.0.view", @"/Views/Store/ProductAdidas.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\_ViewImports.cshtml"
using ProjectCodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\_ViewImports.cshtml"
using ProjectCodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3877bdde7cac57f8990004e8332ad97730c009", @"/Views/Store/ProductAdidas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e72dd49793071f5853bba01ab98f9413436a64", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_ProductAdidas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectCodeFirst.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Store\ProductAdidas.cshtml"
  
    ViewData["Title"] = "ProductAdidas";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""bg-light py-3"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 mb-0""><a href=""index.html"">Trang chủ</a> <span class=""mx-2 mb-0"">/</span> <strong class=""text-black"">Tất cả sản phẩm</strong></div>
        </div>
    </div>
</div>

<div class=""site-section"">
    <div class=""container"">

        <div class=""row mb-5"">
            <div class=""col-md-9 order-2"">

                <div class=""row"">
                    <div class=""col-md-12 mb-5"">
                        <div class=""float-md-left mb-4""><h2 class=""text-black h5"">Tất cả các sản phẩm </h2></div>
                        <div class=""d-flex"">
                            <div class=""dropdown mr-1 ml-md-auto"">
                                <button type=""button"" class=""btn btn-secondary btn-sm dropdown-toggle"" id=""dropdownMenuOffset"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    Latest
                                </butt");
            WriteLiteral(@"on>
                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuOffset"">
                                    <a class=""dropdown-item"" href=""#"">Nam</a>
                                    <a class=""dropdown-item"" href=""#"">Nữ</a>
                                </div>
                            </div>
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-secondary btn-sm dropdown-toggle"" id=""dropdownMenuReference"" data-toggle=""dropdown"">Reference</button>
                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuReference"">
                                    <a class=""dropdown-item"" href=""#"">Relevance</a>
                                    <a class=""dropdown-item"" href=""#"">Name, A to Z</a>
                                    <a class=""dropdown-item"" href=""#"">Name, Z to A</a>
                                    <div class=""dropdown-divider""></div>
                          ");
            WriteLiteral(@"          <a class=""dropdown-item"" href=""#"">Giá từ thấp lên cao</a>
                                    <a class=""dropdown-item"" href=""#"">Giá từ cao xuống thấp</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row mb-5"">
");
#nullable restore
#line 52 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Store\ProductAdidas.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-sm-6 col-lg-4 mb-4"" data-aos=""fade-up"">
                            <div class=""block-4 text-center border"">
                                <figure class=""block-4-image"">
                                    <a href=""shop-single.html""><img");
            BeginWriteAttribute("src", " src=\"", 2920, "\"", 2965, 1);
#nullable restore
#line 57 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Store\ProductAdidas.cshtml"
WriteAttributeValue("", 2926, Html.DisplayFor(modelItem=>item.IMAGE), 2926, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image placeholder\" class=\"img-fluid\"></a>\r\n                                </figure>\r\n                                <div class=\"block-4-text p-4\">\r\n                                    <h3><a href=\"shop-single.html\">");
#nullable restore
#line 60 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Store\ProductAdidas.cshtml"
                                                              Write(Html.DisplayFor(modelItem => item.NAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    ");
#nullable restore
#line 61 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Store\ProductAdidas.cshtml"
                               Write(Html.ActionLink("Thêm vào giỏ hàng", "AddItem", "Cart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <p class=\"text-primary font-weight-bold\">");
#nullable restore
#line 62 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Store\ProductAdidas.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => item.PRICE));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 66 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Store\ProductAdidas.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""row"" data-aos=""fade-up"">
                    <div class=""col-md-12 text-center"">
                        <div class=""site-block-27"">
                            <ul>
                                <li><a href=""#"">&lt;</a></li>
                                <li class=""active""><span>1</span></li>
                                <li><a href=""#"">2</a></li>
                                <li><a href=""#"">3</a></li>
                                <li><a href=""#"">4</a></li>
                                <li><a href=""#"">5</a></li>
                                <li><a href=""#"">&gt;</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-md-3 order-1 mb-5 mb-md-0"">
                <div class=""border p-4 rounded mb-4"">
                    <h3 class=""mb-3 h6 text-uppercase text-black d-block"">Danh mục</h3>
                    ");
            WriteLiteral(@"<ul class=""list-unstyled mb-0"">
                        <li class=""mb-1""><a href=""#"" class=""d-flex""><span>Men</span> <span class=""text-black ml-auto"">(2,220)</span></a></li>
                        <li class=""mb-1""><a href=""#"" class=""d-flex""><span>Women</span> <span class=""text-black ml-auto"">(2,550)</span></a></li>
                    </ul>
                </div>

                <div class=""border p-4 rounded mb-4"">
                    <div class=""mb-4"">
                        <h3 class=""mb-3 h6 text-uppercase text-black d-block"">Lọc giá</h3>
                        <div id=""slider-range"" class=""border-primary""></div>
                        <input type=""text"" name=""text"" id=""amount"" class=""form-control border-0 pl-0 bg-white""");
            BeginWriteAttribute("disabled", " disabled=\"", 5362, "\"", 5373, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>

                    <div class=""mb-4"">
                        <h3 class=""mb-3 h6 text-uppercase text-black d-block"">Kích cỡ</h3>
                        <label for=""s_sm"" class=""d-flex"">
                            <input type=""checkbox"" id=""s_sm"" class=""mr-2 mt-1""> <span class=""text-black"">Nhỏ</span>
                        </label>
                        <label for=""s_md"" class=""d-flex"">
                            <input type=""checkbox"" id=""s_md"" class=""mr-2 mt-1""> <span class=""text-black"">Trung bình</span>
                        </label>
                        <label for=""s_lg"" class=""d-flex"">
                            <input type=""checkbox"" id=""s_lg"" class=""mr-2 mt-1""> <span class=""text-black"">Lớn</span>
                        </label>
                    </div>

                    <div class=""mb-4"">
                        <h3 class=""mb-3 h6 text-uppercase text-black d-block"">Màu sắc</h3>
                        <a href=""#"" class=""d-flex color-it");
            WriteLiteral(@"em align-items-center"">
                            <span class=""bg-danger color d-inline-block rounded-circle mr-2""></span> <span class=""text-black"">Đỏ</span>
                        </a>
                        <a href=""#"" class=""d-flex color-item align-items-center"">
                            <span class=""bg-success color d-inline-block rounded-circle mr-2""></span> <span class=""text-black"">Xanh lá</span>
                        </a>
                        <a href=""#"" class=""d-flex color-item align-items-center"">
                            <span class=""bg-info color d-inline-block rounded-circle mr-2""></span> <span class=""text-black"">Xanh dương</span>
                        </a>
                        <a href=""#"" class=""d-flex color-item align-items-center"">
                            <span class=""bg-primary color d-inline-block rounded-circle mr-2""></span> <span class=""text-black"">Đen</span>
                        </a>
                    </div>

                </div>
            </");
            WriteLiteral(@"div>
        </div>

        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""site-section site-blocks-2"">
                    <div class=""row justify-content-center text-center mb-5"">
                        <div class=""col-md-7 site-section-heading pt-4"">
                            <h2>Categories</h2>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-6 col-md-6 col-lg-4 mb-4 mb-lg-0"" data-aos=""fade"" data-aos-delay="""">
                            <a class=""block-2-item"" href=""#"">
                                <figure class=""image"">
                                    <img src=""images/women.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8164, "\"", 8170, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                </figure>
                                <div class=""text"">
                                    <span class=""text-uppercase"">Collections</span>
                                    <h3>Women</h3>
                                </div>
                            </a>
                        </div>
                        <div class=""col-sm-6 col-md-6 col-lg-4 mb-5 mb-lg-0"" data-aos=""fade"" data-aos-delay=""100"">
                            <a class=""block-2-item"" href=""#"">
                                <figure class=""image"">
                                    <img src=""images/children.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8831, "\"", 8837, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                </figure>
                                <div class=""text"">
                                    <span class=""text-uppercase"">Collections</span>
                                    <h3>Children</h3>
                                </div>
                            </a>
                        </div>
                        <div class=""col-sm-6 col-md-6 col-lg-4 mb-5 mb-lg-0"" data-aos=""fade"" data-aos-delay=""200"">
                            <a class=""block-2-item"" href=""#"">
                                <figure class=""image"">
                                    <img src=""images/men.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9496, "\"", 9502, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                </figure>
                                <div class=""text"">
                                    <span class=""text-uppercase"">Collections</span>
                                    <h3>Men</h3>
                                </div>
                            </a>
                        </div>
                    </div>

                </div>
            </div>
        </div>

    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectCodeFirst.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
