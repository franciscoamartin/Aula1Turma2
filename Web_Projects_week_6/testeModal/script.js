$('#topup').on('show.bs.modal', function (e) {
  var price = $(e.relatedTarget).data('price');
  var contact = $('#name').val();
  var number = $('#no').val();
  //Pass Values in modal

  $('#TopUP, #TitleTopup').html(price);
  $('#Name').html(contact);
  $('#Contact').html(number);
});
