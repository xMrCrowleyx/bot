using System; // access to basic stuff in .NET
using System.Collections.Generic; // access to things like List<T> (T = value type) in .NET
using System.Linq; // necessary to cast IEnumerables to i.e. a list or array
using System.Threading; // used for putting the thread to sleep
using KarelazisBot; // base access to enumerators, Windows API and such
using KarelazisBot.Objects; // access to all the objects

public class Test
{
    public static void Main(Client client)
    {
        string spellName = "utevo lux";
        ushort spellMana = 25;
        Random rand = new Random();
        while (true)
        {
            Thread.Sleep(rand.Next(1000 * 2, 1000 * 5));

            if (client.Player.Mana < spellMana || client.Player.ManaPercent < 80) continue;
            client.Packets.Say(spellName);
        }
    }
}
