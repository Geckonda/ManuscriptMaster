package com.MM.ManuscriptMaster.controller;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.MM.ManuscriptMaster.dto.request.auth.AuthRequest;
import com.MM.ManuscriptMaster.dto.response.auth.AuthResponse;
import com.MM.ManuscriptMaster.infrastructure.auth.AuthService;

import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;


@RestController
@RequestMapping("/api/auth")
@RequiredArgsConstructor
public class AuthController {
    private final AuthService authService;


    @PostMapping("login")
    public AuthResponse postMethodName(@RequestBody AuthRequest request) {
        return authService.login(request);        
    }
    
}
