using AutoMapper;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Domain.SeedWork;
using RickAndMortyAPIApp.Infrastructure.DTOs;
using RickAndMortyAPIApp.Logger;

namespace RickAndMortyAPIApp.Auth.Handlers;

public class RegistrationHandler
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly CustomLogger _customLogger;

    
    public RegistrationHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _customLogger = new CustomLogger();
    }
    public async Task<UserDTO> Handle(UserDTO userDto)
    {
        UserEntity user = _mapper.Map<UserDTO, UserEntity>(userDto);
        _customLogger.LogInformation($"User {user.Username} with password {user.Password}",null );
        var _userRepository = _unitOfWork.GetRepository<UserEntity>();
        await _userRepository.AddAsync(user);
        await _unitOfWork.SaveChangesAsync();
        
        return _mapper.Map<UserEntity, UserDTO>(user);
    }
    
}