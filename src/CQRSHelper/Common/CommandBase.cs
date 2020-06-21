using System;

namespace CQRSHelper._Common
{
    public class CommandBase : ICommand
    {
        public Guid Id { get; }

        public CommandBase()
        {
            this.Id = Guid.NewGuid();
        }

        protected CommandBase(Guid id)
        {
            this.Id = id;
        }
    }
    public abstract class CommandBase<TResult> : ICommand<TResult>
    {
        public Guid Id { get; }
        public string UserId { get; set; } = null;
        public bool IsAnonymous => String.IsNullOrEmpty(UserId);

        protected CommandBase()
        {
            this.Id = Guid.NewGuid();
        }

        protected CommandBase(Guid id)
        {
            this.Id = id;
        }

    }

    public abstract class InternalCommandBase : ICommand
    {
        public Guid Id { get; }

        protected InternalCommandBase(Guid id)
        {
            this.Id = id;
        }
    }

    public abstract class InternalCommandBase<TResult> : ICommand<TResult>
    {
        public Guid Id { get; }

        protected InternalCommandBase()
        {
            this.Id = Guid.NewGuid();
        }

        protected InternalCommandBase(Guid id)
        {
            this.Id = id;
        }
    }
}
