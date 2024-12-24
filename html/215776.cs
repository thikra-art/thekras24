215776.S24
    < !DOCTYPE html >
 < html lang = "ar" >
  < head >
  
      < meta charset = "UTF-8" >
   
       < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
      
          < title > ���� ���� </ title >
         
             < style >
                 body {
    font - family: Arial, sans - serif;
    background - color: #fce4ec;
            color: #880e4f;
            margin: 0;
padding: 0;
}
header
{
    background - color: #f06292;
            color: #ffffff;
            text - align: center;
padding: 20px;
}
nav ul
{
    list-style: none;
    padding: 0;
}
nav ul li {
            display: inline;
margin - right: 15px;
        }
        nav ul li a {
            color: #ffffff;
            text - decoration: none;
        }
        main
{
padding: 20px;
}
footer
{
    background - color: #f06292;
            color: #ffffff;
            text - align: center;
padding: 10px;
position: fixed;
    width: 100 %;
bottom: 0;
}
        .article - list article
{
    background - color: #f8bbd0;
            margin - bottom: 20px;
padding: 20px;
    border - radius: 8px;
}
        .article - list article h3
{
    margin-top: 0;
}
        .article - list article a
{
    color: #d81b60;
            text-decoration: none;
}
        .article - list article a:hover
{
    text - decoration: underline;
}
        .related - articles ul
{
    list - style: none;
padding: 0;
}
        .related - articles ul li
{
    margin-bottom: 10px;
}
        .related - articles ul li a {
            color: #d81b60;
            text - decoration: none;
        }
        .related - articles ul li a:hover
{
    text - decoration: underline;
}
        .form label
{
    display: block;
    margin-bottom: 5px;
}
        .form input, .form textarea {
            width: 100 %;
padding: 8px;
margin - bottom: 10px;
border: 1px solid #d81b60;
            border-radius: 4px;
        }
        .form button
{
    background-color: #d81b60;
            color: #ffffff;
            padding: 10px 15px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}
        .form button:hover
{
    background - color: #ad1457;
        }
    </ style >
</ head >
< body >
    < header >
        < h1 > ���� ���� </ h1 >
   
           < img src = "logo.png" alt = "���� ������" >
      
              < nav >
      
                  < ul >
      
                      < li >< a href = "index.html" > �������� </ a ></ li >
         
                         < li >< a href = "articles.html" > �������� </ a ></ li >
            
                            < li >< a href = "about.html" > ��� ������ </ a ></ li >
                   
                                   < li >< a href = "contact.html" > ���� ��� </ a ></ li >
                          
                                      </ ul >
                          
                                  </ nav >
                          
                              </ header >
                          
                              < main id = "home" >
                           
                                   < section >
                           
                                       < h2 > �������� ������ �����</h2>
                                          <div class= "article-list" >
                              
                                              < article >
                              
                                                  < h3 > ��������� ��������: �� �� ������</ h3 >
                                 
                                                     < p > �� ������ ������ �� ����������ǡ ����� ������ ���� ����� �������. �� ��� ������ ������ ���� �������� ���� �� ������� �� ���� ������ �� �������� ������...</p>
                    <a href="#article1">����� ������</a>
                </article>
                <article>
                    <h3>����� �������� ������� �� ����� ������</h3>
                    <p>�� ����� ����� ����� ���� �� ������� ������ ��� ������� �������. �� ��� ������ ���� ����� ������ ��� ����� �������� �������� ������� ������ �����...</p>
                    <a href="#article2">����� ������</a>
                </article>
            </div>
        </section>
        <section>
            <h2>���� ��������</h2>
            <div>
                <img src="article1.jpg" alt="��������� ��������">
                <img src="article2.jpg" alt="����� �������� �������">
            </div>
        </section>
    </main>
    <footer>
        <p>������� ������� ����� ����� � 2024 ���� ����</p>
    </footer>
</body>
</html>
// ���� �� ����� ������� ������� ��� ����� ��������
document.addEventListener("DOMContentLoaded", function() {
    console.log("Document is fully loaded and parsed");

// ����� ����� ��� ������� ��� ������ �����
const links = document.querySelectorAll('nav ul li a');
links.forEach(link => {
link.addEventListener('mouseover', function() {
    this.style.color = '#d81b60';
});
link.addEventListener('mouseout', function() {
    this.style.color = '#ffffff';
});
    });

// ����� ���� ������ ��� �����
const articleImages = document.querySelectorAll('.article-list img');
articleImages.forEach(img => {
img.addEventListener('click', function() {
    this.src = 'article2.jpg'; // ����� ���� ������ ��� �����
});
    });

// ������ �� ����� ������� ��� �������
const contactForm = document.querySelector('form');
contactForm.addEventListener('submit', function(event) {
    const name = document.getElementById('name').value;
    const email = document.getElementById('email').value;
    const message = document.getElementById('message').value;

    if (name === '' || email === '' || message === '')
    {
        alert('������ ��� ���� ������');
            event.preventDefault(); // ����� ������� ��� ���� ������ �����
    }
});
});
