﻿using Blblan.Data.Entities;

namespace Blblan.Data.Repositories
{
    public class ConversationRepository : Repository<Conversation>
    {
        public ConversationRepository()
            : base(null)
        {

        }

        public ConversationRepository(BlblanDbContext context) : base(context)
        {
        }
    }
}
