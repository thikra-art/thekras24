// تأكد من تحميل الوثيقة بالكامل قبل تنفيذ السكريبت
document.addEventListener("DOMContentLoaded", function() {
    console.log("Document is fully loaded and parsed");

    // تأثير تغيير لون الروابط عند المرور عليها
    const links = document.querySelectorAll('nav ul li a');
    links.forEach(link => {
        link.addEventListener('mouseover', function() {
            this.style.color = '#d81b60';
        });
        link.addEventListener('mouseout', function() {
            this.style.color = '#ffffff';
        });
    });

    // تغيير صورة المقال عند النقر
    const articleImages = document.querySelectorAll('.article-list img');
    articleImages.forEach(img => {
        img.addEventListener('click', function() {
            this.src = 'article2.jpg'; // تغيير مسار الصورة عند النقر
        });
    });

    // التحقق من نموذج الاتصال قبل الإرسال
    const contactForm = document.querySelector('form');
    contactForm.addEventListener('submit', function(event) {
        const name = document.getElementById('name').value;
        const email = document.getElementById('email').value;
        const message = document.getElementById('message').value;

        if (name === '' || email === '' || message === '') {
            alert('الرجاء ملء جميع الحقول');
            event.preventDefault(); // إلغاء الإرسال إذا كانت الحقول فارغة
        }
    });
});
