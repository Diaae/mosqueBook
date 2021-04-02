using AutoMapper;
using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Dto;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Services
{
    public class MosqueService
    {
        private readonly IMosqueRepository _mosqueRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public MosqueService(
            IMosqueRepository mosqueRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _mosqueRepository = mosqueRepository;
            _uow = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MosqueDto>> ListAll()
        {
            var list = await _mosqueRepository.ListAll();
           return  _mapper.Map<IEnumerable<MosqueDto>>(list);

        }

        public async Task<int> Save(MosqueDto mosqueDto)
        {
            var mosque = _mapper.Map<Mosque>(mosqueDto);
            if (_mosqueRepository.Exists(mosque))
            {
                _mosqueRepository.Update(mosque);
            }
            else
            {

                _mosqueRepository.Add(mosque);
            }
            return await _uow.CommitAsync();
        }

        public async Task<MosqueDto> FindById(Guid id)
        {
           var mosque = await _mosqueRepository.FindById(id);

            return _mapper.Map<MosqueDto>(mosque);
        }

        public async Task Remove(Guid mosqueId)
        {
            var mosque = await _mosqueRepository.FindById(mosqueId);
            _mosqueRepository.Remove(mosque);
        }

    }
}
