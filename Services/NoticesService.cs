using Microsoft.EntityFrameworkCore;
using Sample_MVCWebApp.Models;

namespace Services
{
    public class NoticesService
    {
        private readonly AppDbContext _context;

        public NoticesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<NoticeViewModel> DetailsAsync(int? id)
        {
            if (id == null || _context.Notices == null)
            {
                return null;
            }

            var notice = await _context.Notices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notice == null)
            {
                return null;
            }
            return notice;
        }

        public async Task<IEnumerable<NoticeViewModel>> IndexAsync()
        {
            return await _context.Notices.ToListAsync();
        }

        public async Task CreateAsync(NoticeViewModel notice)
        {
            _context.Add(notice);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(NoticeViewModel notice)
        {
                _context.Update(notice);
                await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int? id)
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
        }
    }
}