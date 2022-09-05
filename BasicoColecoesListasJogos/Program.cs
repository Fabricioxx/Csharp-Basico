using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicoColecoesListasJogos
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            //variaveis
            float vida;
            int speed;
            string enemyName;

            //Array - vetores
            int[] intArray = new int[4];
            int[] intArray2 = new int[] {1,2,3,4 };

            //Colections - listas
            List<int> intList = new List<int>();
            List<int> intList2 = new List<int>() {1,2,3,4};

            EnemyWeapon weapon; //instanciar uma classe



            //metodo
            void Movement()
            {

                intList.Add(1); //adicionar na lista
                intList2.Remove(1); //remover da lista


                //laços de repetição foreach e for
                foreach (var item in intList2)
                {

                }

                for (int i = 0; i < intArray.Length; i++)
                {

                    intArray[i] = 1;

                }





                //condição
                if (speed >= 0 && vida > 0)
                {
                    //---

                }
                else
                {
                    //---

                }

            }

            //metodo
            void Dead()
            {
                //condição
                if(vida <= 0)
                {
                  //---

                }

            }

            void Attack()
            {

                //adicionando valores nos atributos da outra classe que foi instanciada
                weapon.damage = 30;
                weapon.fireRate = 0.4f;

                //chamando um metodo publico de outra classe que já esta instanciada
                weapon.Shoot();

            }



        }
    }

    
    public class EnemyWeapon // uma segunda classe
    {

        public float damage;
        public float fireRate;

       public void Shoot()
        {

            
        }


    }









}
