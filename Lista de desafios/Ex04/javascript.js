function Ex04(conteudo){
    var paragrafo = document.getElementById(conteudo).style.display;

    if(paragrafo == "none"){
        document.getElementById(conteudo).style.display = 'block';
    }
    else{
        document.getElementById(conteudo).style.display = 'none'; 
    }
   
}