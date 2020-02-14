//https://stackoverflow.com/questions/5180382/convert-json-data-to-a-html-table

// Builds the HTML Table out of myList.
function buildHtmlTable(selector) {
  var myList;

  var today = new Date();
  var dd = String(today.getDate()).padStart(2, '0');
  var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
  var yy = today.getFullYear().toString().substr(-2);

  $.ajax({
    //url: 'http://csego.cameronanderson.info/' + dd + '/' + mm + '/' + yy,
    url: 'http://206.198.179.69:31415/' + dd + '/' + mm + '/' + yy,
    type: 'GET',
    dataType: 'application/json',
    complete: function(data){
      myList = JSON.parse(data.responseText);
      console.log(myList);


      var columns = addAllColumnHeaders(myList, selector);

      for (var i = 0; i < myList.length; i++) {
        var row$ = $('<tr/>');
        var x = 0
        for (var colIndex = 0; colIndex < columns.length; colIndex++) {
          var cellValue = myList[i][columns[colIndex]];
          if (cellValue == null) cellValue = "";
          row$.append($('<td/>').html(cellValue).addClass('column-' + x));
          x++;
        }
        $(selector).append(row$);
      }

    }
  });
}

// Adds a header row to the table and returns the set of columns.
// Need to do union of keys from all records as some records may not contain
// all records.
function addAllColumnHeaders(myList, selector) {
  var columnSet = [];
  var headerTr$ = $('<tr/>');

  for (var i = 0; i < myList.length; i++) {
    var rowHash = myList[i];
    var x = 0;
    for (var key in rowHash) {
      if ($.inArray(key, columnSet) == -1) {
        columnSet.push(key);
        headerTr$.append($('<th/>').html(key).addClass('column-' + x));
        x++;
      }
    }
  }
  $(selector).append(headerTr$);

  return columnSet;
}


function refresh(){
  $.ajax({
    //url: 'http://csego.cameronanderson.info/fetch',
    url: 'http://206.198.179.69:31415/fetch',
    type: 'GET',
    dataType: 'application/json',
    complete: function(data){
      alert("refreshed")
      window.location.reload();
    }
  });
}