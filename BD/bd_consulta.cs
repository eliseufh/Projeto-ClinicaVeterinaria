using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using clinicaVeterinaria.Construtores;
using clinicaVeterinaria.Formularios;
using System.Data;

namespace clinicaVeterinaria.BD
{
    internal class bd_consulta
    {
        public void AdicionarConsulta(consulta obj)
        {

            string sql = @"INSERT INTO clinica_veterinaria.consulta (
                            id_animal, 
                            nome_medico, 
                            tipo_consulta, 
                            data_consulta, 
                            prox_visita, 
                            diagnostico, 
                            ato_medico, 
                            observacoes, 
                            peso,
                            prescricao_medica
                        ) 
                        VALUES (
                            @id_animal,
                            @nome_medico,
                            @tipo_consulta,
                            @data_consulta,
                            @prox_visita,
                            @diagnostico,
                            @ato_medico,
                            @observacoes,
                            @peso,
                            @prescricao_medica
                        )";

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strConexao))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(sql, ligabd))
                    {
                        ligacao.Parameters.AddWithValue("@id_animal", obj.id_animal);
                        ligacao.Parameters.AddWithValue("@nome_medico", obj.nome_medico);
                        ligacao.Parameters.AddWithValue("@tipo_consulta", obj.tipo_consulta);
                        ligacao.Parameters.AddWithValue("@data_consulta", obj.data_consulta);
                        ligacao.Parameters.AddWithValue("@prox_visita", obj.prox_visita);
                        ligacao.Parameters.AddWithValue("@diagnostico", obj.diagnostico);
                        ligacao.Parameters.AddWithValue("@ato_medico", obj.ato_medico);
                        ligacao.Parameters.AddWithValue("@observacoes", obj.observacoes);
                        ligacao.Parameters.AddWithValue("@peso", obj.peso);
                        ligacao.Parameters.AddWithValue("@prescricao_medica", obj.prescricao_medica);

                        ligacao.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static DataTable GetConsulta()
        {
            var dt = new DataTable();

            var query = "SELECT * FROM clinica_veterinaria.consulta";

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strConexao))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlDataAdapter(query, ligabd))
                    {
                        ligacao.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }
        public void DelConsulta(int id_consulta)
        {
            var query = "DELETE FROM clinica_veterinaria.consulta WHERE id_consulta= '" + id_consulta + "'";
            try
            {
                using (var ligabd = new MySqlConnection(conexao.strConexao))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(query, ligabd))
                    {
                        ligacao.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditarConsulta(int id_consulta, consulta obj)
        {
            string query = "UPDATE clinica_veterinaria.consulta SET " +
                           "id_animal = @id_animal, " +
                           "nome_medico = @nome_medico, " +
                           "tipo_consulta = @tipo_consulta, " +
                           "data_consulta = @data_consulta, " +
                           "prox_visita = @prox_visita, " +
                           "diagnostico = @diagnostico, " +
                           "ato_medico = @ato_medico, " +
                           "observacoes = @observacoes, " +
                           "peso = @peso, " +
                           "prescricao_medica = @prescricao_medica " +
                           "WHERE id_consulta = @id_consulta";

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strConexao))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(query, ligabd))
                    {
                        ligacao.Parameters.AddWithValue("@id_animal", obj.id_animal);
                        ligacao.Parameters.AddWithValue("@nome_medico", obj.nome_medico);
                        ligacao.Parameters.AddWithValue("@tipo_consulta", obj.tipo_consulta);
                        ligacao.Parameters.AddWithValue("@data_consulta", obj.data_consulta);
                        ligacao.Parameters.AddWithValue("@prox_visita", obj.prox_visita);
                        ligacao.Parameters.AddWithValue("@diagnostico", obj.diagnostico);
                        ligacao.Parameters.AddWithValue("@ato_medico", obj.ato_medico);
                        ligacao.Parameters.AddWithValue("@observacoes", obj.observacoes);
                        ligacao.Parameters.AddWithValue("@peso", obj.peso);
                        ligacao.Parameters.AddWithValue("@prescricao_medica", obj.prescricao_medica);
                        ligacao.Parameters.AddWithValue("@id_consulta", id_consulta);

                        ligacao.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mensagem de erro
            }
        }
        public consulta ObterConsultaPorID(int id)
        {
            consulta consulta = new consulta();

            string sql = "SELECT * FROM clinica_veterinaria.consulta WHERE id_consulta = @id";

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strConexao))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(sql, ligabd))
                    {
                        ligacao.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = ligacao.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                consulta.id_animal = Convert.ToInt32(reader["id_animal"]);
                                consulta.nome_medico = reader["nome_medico"].ToString();
                                consulta.tipo_consulta = reader["tipo_consulta"].ToString();
                                consulta.data_consulta = Convert.ToDateTime(reader["data_consulta"]);
                                consulta.prox_visita = Convert.ToDateTime(reader["prox_visita"]);
                                consulta.diagnostico = reader["diagnostico"].ToString();
                                consulta.ato_medico = reader["ato_medico"].ToString();
                                consulta.observacoes = reader["observacoes"].ToString();
                                consulta.peso = Convert.ToDouble(reader["peso"]);
                                consulta.prescricao_medica = reader["prescricao_medica"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return consulta;
        }
    }
}
