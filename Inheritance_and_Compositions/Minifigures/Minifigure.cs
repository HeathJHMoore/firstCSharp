using Inheritance_and_Compositions.Minifigures.Pieces;

namespace Inheritance_and_Compositions.Minifigures
{
    class Minifigure
    {
        readonly Head _head;
        readonly Legs _legs;

        public Minifigure(Head head, Legs legs)
        {
            _head = head;
            _legs = legs;
        }

        public void Battle()
        {
            _head.Talk();
            _legs.Kick();
        }
    }
}
