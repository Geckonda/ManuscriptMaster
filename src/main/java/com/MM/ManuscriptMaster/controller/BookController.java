package com.MM.ManuscriptMaster.controller;

import com.MM.ManuscriptMaster.dto.request.BookCreateRequest;
import com.MM.ManuscriptMaster.dto.request.BookUpdateRequest;
import com.MM.ManuscriptMaster.dto.response.BookResponse;
import com.MM.ManuscriptMaster.dto.response.BookSimpleResponse;
import com.MM.ManuscriptMaster.service.BookService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/books")
@RequiredArgsConstructor
public class BookController {
    private final BookService bookService;

    /**
     * GET /api/books - Получить краткий список всех книг (preview)
     * @return Список книг с основной информацией (id, title, rating, status, modificator)
     */
    @GetMapping
    public List<BookSimpleResponse> getBooksPreview() {
        return bookService.getBooksPreview();
    }

    /**
     * GET /api/books/detailed - Получить полный список всех книг с эпизодами
     * @return Список книг со все информацией, включая автора, жанр и эпизоды
     */
    @GetMapping("/detailed")
    public List<BookResponse> getBooksDetailed() {
        return bookService.getBooksDetailed();
    }

    /**
     * GET /api/books/{id}/preview - Получить одну книгу в режиме preview
     * @param id ID книги
     * @return Книга с основной информацией
     */
    @GetMapping("/{id}/preview")
    public BookSimpleResponse getBookPreview(@PathVariable Long id) {
        return bookService.getBookPreview(id);
    }

    /**
     * GET /api/books/{id} - Получить одну книгу с полной информацией и эпизодами
     * @param id ID книги
     * @return Полная информация о книге, включая автора, жанр и все эпизоды
     */
    @GetMapping("/{id}")
    public BookResponse getBook(@PathVariable Long id) {
        return bookService.getBook(id);
    }

    /**
     * POST /api/books - Создать новую книгу
     * @param request Запрос на создание книги
     * @return Созданная книга с полной информацией
     */
    @PostMapping
    public BookResponse create(@RequestBody BookCreateRequest request) {
        return bookService.create(request);
    }

    /**
     * PUT /api/books/{id} - Обновить существующую книгу
     * @param id ID книги
     * @param request Запрос на обновление книги
     * @return Обновленная книга с полной информацией
     */
    @PutMapping("/{id}")
    public BookResponse update(@PathVariable Long id, @RequestBody BookUpdateRequest request) {
        return bookService.update(id, request);
    }

    /**
     * DELETE /api/books/{id} - Удалить книгу
     * @param id ID книги
     */
    @DeleteMapping("/{id}")
    public void delete(@PathVariable Long id) {
        bookService.delete(id);
    }
}
