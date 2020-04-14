using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.ATM
{
    class atm
    {
        public int Ballance { get; set; }

        public List<Client> Accounts { get; set; } = new List<Client>();

        public string dispencemoney(string accountId, int amountToWithdraw)
        {
            Client client = null;

            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Id == accountId)
                {
                    client.Id = accountId;
                }
            }



            return client;

        }
    }
}
