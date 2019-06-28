using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Tetris.ViewModels
{
    public abstract class ViewModelBase : ObservableObject
    {
        protected bool Set<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
            {
                return false;
            }

            field = newValue;
            RaisePropertyChanged(propertyName);
            return true;
        }
    }
}
