$(document).ready(function(){
	$('#tabela').empty(); //Limpando a tabela
	$.ajax({
		type:'get',		//Definimos o método HTTP usado
		dataType: 'json',	//Definimos o tipo de retorno
		url: 'http://localhost:51815/api/Usuario',//Definindo o arquivo onde serão buscados os dados
		success: function(dados){
			for(var i=0;dados.length>i;i++){
				//Adicionando registros retornados na tabela
				$('#tabela').append('<tr><td>'+dados[i].Id+'</td><td>'+dados[i].nome+
				'</td><td>'+dados[i].endereco+'</td><td>'+dados[i].telefone+
				'</td><td><input type="button" onclick="insereTexto('+dados[i].Id+')" value="Excluir Usuario">'+
				'</td><td><input type="button" href="PUT_Usuario.html" value="Editar Usuario"></td></tr>');
				
			}
		}
	});
});