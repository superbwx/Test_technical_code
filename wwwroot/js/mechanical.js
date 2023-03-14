serverApi = "/";

$(document).ready(function () {
  console.log("ready!");
});

function segitiga() {
  callData($("#inputNilai").val(), "segitiga");
}

function ganjil() {
  callData($("#inputNilai").val(), "ganjil");
}

function prima() {
  callData($("#inputNilai").val(), "prima");
}

function callData(number, type) {
  $.ajax({
    type: "GEt",
    url: type + "/" + number,
    crossDomain: true,
    dataType: "json",
    success: function (data) {
      console.log(data);
    },
    error: function (e) {
      console.log("Gagal");
    },
  });
}
