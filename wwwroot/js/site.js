// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// var commonMdl = 
// $(function () {
//   function initdata(url) {
//     $.ajax({
//       type: "GET",
//       url: url,
//       dataType: "html",
//       complete: (xhr, status) => {
//         console.log("complete");
//         console.log(xhr.responseText);
//         $load = $($.parseHTML(xhr.responseText));
//         $load.filter(".holder").filter(function (idx) {
//           $("#" + $(this).attr("id")).html(this.innerHTML);
//         });
//       },
//       error: (xhr, status, error) => {
//         console.log("error");
//         console.log(xhr);
//       },
//     });
//   }

//   $("form").submit(function (event) {
//     $(".errs").html("");
//     $.ajax({
//       type: this["method"],
//       url: this["action"],
//       data: $(this).serialize(),
//       dataType: "html",
//       complete: (xhr, status) => {
//         repcontent(xhr.responseJSON);
//       },
//       error: (xhr, status, error) => {
//         console.log(`error`);
//         console.log(error);
//       },
//     });
//     return false;
//   });
// });
