$(document).ready(function(){
	$('#tabela').empty(); //Limpando a tabela
	$.ajax({
		type:'put',		//Definimos o método HTTP usado
        dataType: 'json',	//Definimos o tipo de retorno
        data:'',
		url: 'http://localhost:51815/api/Usuario',//Definindo o arquivo onde serão buscados os dados
		success: function(dados){
			for(var i=0;dados.length>i;i++){
				//Adicionando registros retornados na tabela
				$('#tabela').append('<tr><td>'+dados[i].Id+'</td><td>'+dados[i].nome+
				'</td><td>'+dados[i].endereco+'</td><td>'+dados[i].telefone+
				'</td><td><input type="button" onclick="insereTexto2('+dados[i].Id+')" value="Editar Usuario"></td></tr>');
				
			}
		}
	});
});