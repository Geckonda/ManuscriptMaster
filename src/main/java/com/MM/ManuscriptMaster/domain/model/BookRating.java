package com.MM.ManuscriptMaster.domain.model;

import lombok.AllArgsConstructor;
import lombok.Getter;

@AllArgsConstructor
@Getter
public enum BookRating {
    PLUS18("18+"),
    PLUS16("16+"),
    PLUS12("12+"),
    PLUS6("6+"),
    PLUS0("0+");

    private final String displayName;
}
