function Ex05(){
    var check = document.querySelectorAll('input[type="checkbox"]');
    var botao = document.getElementById("botao");
    var Count = 0;

    for (var i = 0; i < check.length; i++) {
        if (check[i].checked) {
                Count++;
            }
        }

        if (Count >= 2) {
            botao.disabled = false;
        } else {
            botao.disabled = true;
        }
 }