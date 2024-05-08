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
    internal class bd_animal
    {
        public static DataTable GetAnimal()
        {
            var dt = new DataTable();

            var query = "SELECT * FROM clinica_veterinaria.animal";

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

        public void CadastrarAnimal(animal obj)
        {

            string sql = @"INSERT INTO clinica_veterinaria.animal (
                            nome_dono, 
                            contacto_dono, 
                            data_nascimento, 
                            data_ultima_consulta, 
                            tipo_animal, 
                            raça, 
                            sexo, 
                            peso
                        ) 
                        VALUES (
                            @nome_dono,
                            @contacto_dono,
                            @data_nascimento,
                            @data_ultima_consulta,
                            @tipo_animal,
                            @raça,
                            @sexo,
                            @peso
                        )";


            try
            {
                using (var ligabd = new MySqlConnection(conexao.strConexao))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(sql, ligabd))
                    {
                        ligacao.Parameters.AddWithValue("@nome_dono", obj.nome_dono);
                        ligacao.Parameters.AddWithValue("@contacto_dono", obj.contacto_dono);
                        ligacao.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                        ligacao.Parameters.AddWithValue("@data_ultima_consulta", obj.data_ultima_consulta);
                        ligacao.Parameters.AddWithValue("@tipo_animal", obj.tipo_animal);
                        ligacao.Parameters.AddWithValue("@raça", obj.raca);
                        ligacao.Parameters.AddWithValue("@sexo", obj.sexo);
                        ligacao.Parameters.AddWithValue("@peso", obj.peso);
                        ligacao.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DelAnimal(int id_animal)
        {
            var query = "DELETE FROM clinica_veterinaria.animal WHERE id_animal= '" + id_animal + "'";
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

        public void EditarAnimal(int id_animal, animal obj)
        {
            string query = "UPDATE clinica_veterinaria.animal SET " +
                           "nome_dono = @nome_dono, " +
                           "contacto_dono = @contacto_dono, " +
                           "data_nascimento = @data_nascimento, " +
                           "data_ultima_consulta = @data_ultima_consulta, " +
                           "tipo_animal = @tipo_animal, " +
                           "raça = @raça, " +
                           "sexo = @sexo, " +
                           "peso = @peso " +
                           "WHERE id_animal = @id_animal";

            try
            {
                using (var ligabd = new MySqlConnection(conexao.strConexao))
                {
                    ligabd.Open();
                    using (var ligacao = new MySqlCommand(query, ligabd))
                    {
                        ligacao.Parameters.AddWithValue("@nome_dono", obj.nome_dono);
                        ligacao.Parameters.AddWithValue("@contacto_dono", obj.contacto_dono);
                        ligacao.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
                        ligacao.Parameters.AddWithValue("@data_ultima_consulta", obj.data_ultima_consulta);
                        ligacao.Parameters.AddWithValue("@tipo_animal", obj.tipo_animal);
                        ligacao.Parameters.AddWithValue("@raça", obj.raca);
                        ligacao.Parameters.AddWithValue("@sexo", obj.sexo);
                        ligacao.Parameters.AddWithValue("@peso", obj.peso);
                        ligacao.Parameters.AddWithValue("@id_animal", id_animal);

                        ligacao.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mensagem de erro
            }
        }
        public animal ObterAnimalPorID(int id)
        {
            animal animal = new animal();

            string sql = "SELECT * FROM clinica_veterinaria.animal WHERE id_animal = @id";

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
                                animal.nome_dono = reader["nome_dono"].ToString();
                                animal.contacto_dono = reader["contacto_dono"].ToString();
                                animal.data_nascimento = Convert.ToDateTime(reader["data_nascimento"]);
                                animal.data_ultima_consulta = Convert.ToDateTime(reader["data_ultima_consulta"]);
                                animal.tipo_animal = reader["tipo_animal"].ToString();
                                animal.raca = reader["raça"].ToString();
                                animal.sexo = reader["sexo"].ToString();
                                animal.peso = Convert.ToDouble(reader["peso"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return animal;
        }
    }
}
