#pragma checksum "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Partial_Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29b1e6f83f3cb02df878a45ad9a2069ce86b944f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Partial_Update), @"mvc.1.0.view", @"/Views/Home/Partial_Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29b1e6f83f3cb02df878a45ad9a2069ce86b944f", @"/Views/Home/Partial_Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Partial_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<input type=""text"" id=""person""  hidden />
<div class=""modal  fade"" id=""Update"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Güncelleme</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""input-group input-group-sm mb-3"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Ünvan</span>
                    </div>
                    <input id=""unvan2"" type=""text"" class=""form-control"" aria-label=""Sizing example input"" aria-describedby=""inputGroup-sizing-sm"">
                </div>
                <div c");
            WriteLiteral(@"lass=""row"">
                    <div class=""col-md-6"">
                        <table class=""table"">

                            <thead class=""thead-dark"">

                                <tr>
                                    <th scope=""col"">Telefonlar</th>
                                    <th>
                                        <button id=""TelefonInput"" class=""btn btn-sm btn-success  float-right"">+</button>
                                    </th>
                                </tr>

                            </thead>
                            <tbody id=""addTelUpdate"">
                            </tbody>

                        </table>
                    </div>
                    <div class=""col-md-6"">
                        <table class=""table"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th scope=""col"">Adresler</th>
                                    <th>
                ");
            WriteLiteral(@"                        <button id=""AddressInput"" class=""btn btn-sm btn-success  float-right"">+</button>
                                    </th>
                                </tr>
                            </thead>
                            <tbody id=""addAddressUpdate"">
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Çıkış</button>
                <button type=""button"" onclick=""updateData()"" class=""btn btn-primary"">Güncelle</button>
            </div>
        </div>
    </div>
</div>


<script>
    $(""#TelefonInput"").click(function () {
        $(""#addTelUpdate"")
            .append('<tr><th><input type=""text"" placeholder=""Add Phone"" class=""form-control updatephoneNumber""></th><th><button  class=""btn btn-sm btn-danger deleteTel"">x</button></th></tr>');
    });

   ");
            WriteLiteral(@" $(document).on('click', '.deleteTel', function () {
        $(this).parents(""tr"").remove();
    });

    $(""#AddressInput"").click(function () {
        $(""#addAddressUpdate"")
            .append('<tr><th><input type=""text"" placeholder=""Add Address"" class=""form-control updateAddress""></th><th><button  class=""btn btn-sm btn-danger deleteAddress"">x</button></th></tr>');
    });

    $(document).on('click', '.deleteAddress', function () {
        $(this).parents(""tr"").remove();
    });

</script>

<script>
    var editdata = function (id) {

        $(""#person"").val(id);
           
        var phoneTable = $(""#addTelUpdate"");

        var addressTable = $(""#addAddressUpdate"");

        var personID = id;

        var getPhonesUpdate = function () {
            $.ajax({
                url: ""/Home/GetPhones"",
                type: 'GET',
                dataType: 'json',
                beforeSend: function () {
                    phoneTable.html("""");
                },
       ");
            WriteLiteral(@"         data: {
                    ""id"": personID
                },
                success: function (loadData) {
                    
                    $(""#unvan2"").val(loadData.unvan);
                    for (var i = 0; i < loadData.phones.length; i++) {
                        var phone = $(""#addTelUpdate"");
                        phone.append('<tr><th><input type=""text""  class=""form-control updatephoneNumber"" value=""' + loadData.phones[i] + '""></th><th><button  class=""btn btn-sm btn-danger deleteTel"">x</button></th></tr>');
                    }
                },
                error: function (error) {
                    console.log(error.Message);
                },
            });
        };

        var getAddressUpdate = function () {
            $.ajax({
                url: ""/Home/GetAddress"",
                type: 'GET',
                dataType: 'json',
                beforeSend: function () {
                    addressTable.html("""");
                },
     ");
            WriteLiteral(@"           data: {
                    ""id"": personID
                },
                success: function (loadData) {
                    for (var i = 0; i < loadData.length; i++) {
                        var address = $(""#addAddressUpdate"");
                        address.append('<tr><th><input type=""text""  class=""form-control updateAddress"" value=""' + loadData[i].address + '""></th><th><button  class=""btn btn-sm btn-danger deleteAddress"">x</button></th></tr>');
                    }
                },
                error: function (error) {
                    console.log(error.Message);
                },
            });
        };

        getAddressUpdate();
        getPhonesUpdate();
    };
</script>

<script>
    var numbersUp = [];
    var addressUp = [];

    var updateData = function () {

        $('input[type=""text""].updatephoneNumber').each(function () {
            numbersUp.push($(this).val());
        });

        $('input[type=""text""].updateAddress').each(fu");
            WriteLiteral(@"nction () {
            addressUp.push($(this).val());
        });
        var unvanUp = $(""#unvan2"").val();
        var personIDUp = $('#person').val();

        var updateData1 = function () {
            $.ajax({
                url: ""/Home/Update"",
                type: 'POST',
                dataType: 'json',
                data: {
                    ""id"": personIDUp,
                    ""personNum"": numbersUp,
                    ""title"": unvanUp,
                    ""personAddress"": addressUp
                },
                success: function () {
                    alert(""OK"");
                },
                error: function (error) {
                    console.log(error.Message);
                },
            });
        };


        updateData1();
        window.history.go(0)
        window.location.reload()


    };
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
