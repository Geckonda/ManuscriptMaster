package com.MM.ManuscriptMaster.infrastructure.auth;

import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import com.MM.ManuscriptMaster.domain.model.User;
import com.MM.ManuscriptMaster.dto.request.auth.AuthRequest;
import com.MM.ManuscriptMaster.dto.response.auth.AuthResponse;
import com.MM.ManuscriptMaster.exception.NotFoundException;
import com.MM.ManuscriptMaster.repository.UserRepository;

import jakarta.annotation.PostConstruct;
import lombok.RequiredArgsConstructor;

@Service
@RequiredArgsConstructor
public class AuthService {
    private final JwtService jwtService;
    private final UserRepository userRepository;
    private final PasswordEncoder passwordEncoder;


    @PostConstruct
    public void initTestUser()
    {
        if(userRepository.findByEmail("test@example.com").isEmpty())
        {
            User user = new User();
            user.setLogin("testuser");
            user.setNickname("testuser");
            user.setEmail("test@example.com");
            user.setPassword(passwordEncoder.encode("password"));
            userRepository.save(user);
            System.out.println("Тетсовый пользователь создан!");
        }
    }

    public AuthResponse login(AuthRequest request)
    {
        User user = userRepository.findByEmail(request.email())
                        .orElseThrow(() -> new NotFoundException("Пользователь не найден!")) ;
        if(!passwordEncoder.matches(request.password(), user.getPassword()))
        {
            throw new NotFoundException("Неверный пароль!");
        }
        String token = jwtService.generateToken(user.getEmail());
        return new AuthResponse(token);
    }
}
