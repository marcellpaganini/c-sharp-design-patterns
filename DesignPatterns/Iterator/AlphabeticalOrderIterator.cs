using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;

        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                this._position = collection.GetItems().Count;
            }
        }

        public override object Current()
        {
            return this._collection.GetItems()[_position];
        }

        public override int Key()
        {
            return this._position;
        }

        // Returns bool to indicate whether there is another item to move to in the collection
        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.GetItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            return false;
        }

        public override void Reset()
        {
            this._position = this._reverse ? this._collection.GetItems().Count - 1 : 0;
        }
    }
}
