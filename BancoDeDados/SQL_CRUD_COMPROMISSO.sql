INSERT INTO compromisso
(
	id_contato,
    descricao,
    data,
    fl_concluido
) VALUES 
(
	@id_contato,
    @descricao,
    @data,
    'NAO'
)