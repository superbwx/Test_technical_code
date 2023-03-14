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
  document.getElementById("hasilKalkulasi").innerHTML = "";
  $.ajax({
    type: "GEt",
    url: type + "/" + number,
    crossDomain: true,
    dataType: "json",
    success: function (data) {
      console.log(data);
      if (type == "segitiga") {
        showSegitiga(data);
      } else {
        showDeret(data, "Bilangan " + type);
      }
    },
    error: function (e) {
      console.log("Gagal");
    },
  });
}

function showSegitiga(data) {
  var display = "";
  document.getElementById("hasilKalkulasi").innerHTML += "Bentung <br>";
  for (i = 0; i < data.length; i++) {
    display += "<div>" + data[i] + "</div>";
  }
  document.getElementById("hasilKalkulasi").innerHTML += display;
}

function showDeret(data, type) {
  document.getElementById("hasilKalkulasi").innerHTML += type + "<br>";
  document.getElementById("hasilKalkulasi").innerHTML += data.toString();
}
