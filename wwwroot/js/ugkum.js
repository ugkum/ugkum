/**
 * UGKUM Innovation - JavaScript principal
 * Partículas de fondo, scroll animations, navbar y navegación suave
 */
(function () {
    'use strict';

    // ─── Partículas de fondo ─────────────────────────────────────────────
    function initParticles() {
        const canvas = document.getElementById('particles-canvas');
        if (!canvas) return;

        const ctx = canvas.getContext('2d');
        let particles = [];
        let animationId;
        let width, height;

        function resize() {
            width = canvas.width = window.innerWidth;
            height = canvas.height = window.innerHeight;
        }

        function createParticles() {
            const count = Math.min(Math.floor(width * height / 12000), 80);
            particles = [];

            for (let i = 0; i < count; i++) {
                particles.push({
                    x: Math.random() * width,
                    y: Math.random() * height,
                    radius: Math.random() * 1.5 + 0.5,
                    speedX: (Math.random() - 0.5) * 0.4,
                    speedY: (Math.random() - 0.5) * 0.4,
                    opacity: Math.random() * 0.5 + 0.2
                });
            }
        }

        function draw() {
            ctx.clearRect(0, 0, width, height);

            particles.forEach(function (p, i) {
                // Mover partícula
                p.x += p.speedX;
                p.y += p.speedY;

                // Rebotar en bordes
                if (p.x < 0 || p.x > width) p.speedX *= -1;
                if (p.y < 0 || p.y > height) p.speedY *= -1;

                // Dibujar partícula
                ctx.beginPath();
                ctx.arc(p.x, p.y, p.radius, 0, Math.PI * 2);
                ctx.fillStyle = 'rgba(0, 191, 255, ' + p.opacity + ')';
                ctx.fill();

                // Conectar partículas cercanas
                for (let j = i + 1; j < particles.length; j++) {
                    const p2 = particles[j];
                    const dx = p.x - p2.x;
                    const dy = p.y - p2.y;
                    const dist = Math.sqrt(dx * dx + dy * dy);

                    if (dist < 120) {
                        ctx.beginPath();
                        ctx.moveTo(p.x, p.y);
                        ctx.lineTo(p2.x, p2.y);
                        ctx.strokeStyle = 'rgba(123, 97, 255, ' + (0.08 * (1 - dist / 120)) + ')';
                        ctx.lineWidth = 0.5;
                        ctx.stroke();
                    }
                }
            });

            animationId = requestAnimationFrame(draw);
        }

        resize();
        createParticles();
        draw();

        window.addEventListener('resize', function () {
            resize();
            createParticles();
        });

        // Pausar animación cuando la pestaña no está visible (optimización)
        document.addEventListener('visibilitychange', function () {
            if (document.hidden) {
                cancelAnimationFrame(animationId);
            } else {
                draw();
            }
        });
    }

    // ─── Scroll reveal animations ──────────────────────────────────────────
    function initScrollReveal() {
        const elements = document.querySelectorAll('.reveal');
        if (!elements.length) return;

        const observer = new IntersectionObserver(function (entries) {
            entries.forEach(function (entry) {
                if (entry.isIntersecting) {
                    entry.target.classList.add('visible');
                    observer.unobserve(entry.target);
                }
            });
        }, {
            threshold: 0.12,
            rootMargin: '0px 0px -40px 0px'
        });

        elements.forEach(function (el) {
            observer.observe(el);
        });
    }

    // ─── Navbar scroll effect ──────────────────────────────────────────────
    function initNavbar() {
        const navbar = document.querySelector('.ugkum-navbar');
        const navLinks = document.querySelectorAll('.ugkum-nav-link');
        const sections = document.querySelectorAll('section[id]');

        if (!navbar) return;

        window.addEventListener('scroll', function () {
            navbar.classList.toggle('scrolled', window.scrollY > 50);
        }, { passive: true });

        // Resaltar enlace activo según sección visible
        function highlightNav() {
            const scrollPos = window.scrollY + 100;

            sections.forEach(function (section) {
                const top = section.offsetTop;
                const height = section.offsetHeight;
                const id = section.getAttribute('id');

                if (scrollPos >= top && scrollPos < top + height) {
                    navLinks.forEach(function (link) {
                        link.classList.remove('active');
                        if (link.getAttribute('href') === '#' + id) {
                            link.classList.add('active');
                        }
                    });
                }
            });
        }

        window.addEventListener('scroll', highlightNav, { passive: true });

        // Cerrar menú móvil al hacer clic en un enlace
        navLinks.forEach(function (link) {
            link.addEventListener('click', function () {
                const collapse = document.getElementById('mainNav');
                if (collapse && collapse.classList.contains('show')) {
                    const toggler = document.querySelector('.ugkum-toggler');
                    if (toggler) toggler.click();
                }
            });
        });
    }

    // ─── Navegación suave ──────────────────────────────────────────────────
    function initSmoothScroll() {
        document.querySelectorAll('a[href^="#"]').forEach(function (anchor) {
            anchor.addEventListener('click', function (e) {
                const targetId = this.getAttribute('href');
                if (targetId === '#') return;

                const target = document.querySelector(targetId);
                if (target) {
                    e.preventDefault();
                    target.scrollIntoView({ behavior: 'smooth' });
                }
            });
        });
    }

    // ─── Inicialización ────────────────────────────────────────────────────
    document.addEventListener('DOMContentLoaded', function () {
        initParticles();
        initScrollReveal();
        initNavbar();
        initSmoothScroll();
    });
})();
