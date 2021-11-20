USE escola;

SELECT * FROM tbl_disciplina
INNER JOIN tbl_curso;

SELECT * FROM tbl_disciplina
INNER JOIN tbl_curso
ON tbl_disciplina.cod_curso = tbl_curso.cod_curso;

SELECT * FROM tbl_disciplina td
INNER JOIN tbl_curso tc
ON td.cod_curso = tc.cod_curso;

SELECT 
nome_disciplina,
descricao_disciplina,
carga_horaria_disciplina,
nome_curso
FROM tbl_disciplina td
INNER JOIN tbl_curso tc
ON td.cod_curso = tc.cod_curso;

SELECT 
td.nome_disciplina,
td.descricao_disciplina,
td.carga_horaria_disciplina,
tc.nome_curso
FROM tbl_disciplina td
INNER JOIN tbl_curso tc
ON td.cod_curso = tc.cod_curso
WHERE tc.cod_curso = 1;

SELECT 
td.nome_disciplina,
td.descricao_disciplina,
td.carga_horaria_disciplina,
tc.nome_curso
FROM tbl_disciplina td
INNER JOIN tbl_curso tc USING (cod_curso)
WHERE td.cod_disciplina = 1;
