using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBitcoinFirstProject {
    class Program {
        static void Main(string[] args) {

            var k = new Key(); // create a new key
            var pubkey = k.PubKey.GetAddress(Network.Main)); // designate key to main vs test network
            var pvtKeyStr = new Key().ToString(Network.Main); // save private key in text format
            var secret = new BitcoinSecret(pvtKeyStr); //
            var key = secret.PrivateKey; // get my private key
        }
    }
}
