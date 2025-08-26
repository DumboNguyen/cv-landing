import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import { BarChart, Bar, XAxis, YAxis, CartesianGrid, Tooltip, ResponsiveContainer, Cell } from 'recharts';

const data = [
  { name: 'Frontend', value: 90, color: '#224A72FF' },
  { name: 'Backend', value: 75, color: '#647A65FF' },
  { name: 'Tools', value: 65, color: '#1E4A5AFF' },
  { name: 'Soft Skills', value: 90, color: '#D7B75FFF' },
];

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
    <div>
      <div className='header'>
        <div className='header-logo'>
          <img src='/images/NQH-logo1.png'></img>
        </div>
        <div className='header-menu'>
          <div className='header-menu-item'>
            <a href="#">Experience</a>
          </div>
          <div className='header-menu-item'>
            <a href="#">Skill</a>
          </div>
          <div className='header-menu-item'>
            <a href="#">Education</a>
          </div>
          <div className='header-menu-item'>
            <a href="#">Projects</a>
          </div>
          <div className='header-menu-item'>
            <a href="#">Testimonials</a>
          </div>
          <div className='header-menu-item'>
            <a href="#">Contact</a>
          </div>
        </div>
      </div>
      <div className='body'>
        <div className='container'>
          <div className='container-information'>
            <div className='container-information-avatar'>
              <img 
                src="https://via.placeholder.com/120x120/3275B4/FFFFFF?text=A" 
                alt="Alex Avatar" 
                //className="avatar-image"
              />
            </div>
            <div className='container-information-name'>
              <span>Alex Johnson</span>
            </div>
            <div className='container-information-title'>
              <span>Senior Software Engineer | Building Scalable Web Solutions</span>
            </div>
            <div className='container-information-contact'>
              <button className='container-information-primary'>
                <svg className="icon" viewBox="0 0 24 24">
                  <path d="M20 4H4c-1.1 0-1.99.9-1.99 2L2 18c0 1.1.9 2 2 2h16c1.1 0 2-.9 2-2V6c0-1.1-.9-2-2-2zm0 4l-8 5-8-5V6l8 5 8-5v2z"/>
                </svg>
                <span>Email Me</span>
              </button>
              <button className='container-information-secondary'>
                <svg className="icon" viewBox="0 0 24 24" fill="white" stroke="black" stroke-width="1.5">
                  <path d="M6.62 10.79c1.44 2.83 3.76 5.14 6.59 6.59l2.2-2.2c.27-.27.67-.36 1.02-.24 1.12.37 2.33.57 3.57.57.55 0 1 .45 1 1V20c0 .55-.45 1-1 1-9.39 0-17-7.61-17-17 0-.55.45-1 1-1h3.5c.55 0 1 .45 1 1 0 1.25.2 2.45.57 3.57.11.35.03.74-.25 1.02l-2.2 2.2z"/>
                </svg>
                <span>Call Me</span>
              </button>
            </div>
          </div>
          <div className='container-content'>
            <div className='container-content-header'>
              <span>About Me</span>
            </div>
            <div className='container-content-body'>
              <span>
                As a seasoned Senior Software Engineer with a passion for innovation and problem-solving, I specialize in crafting robust, high-performance web applications. My expertise spans full-stack development, with a strong emphasis on user experience and scalable architectures. I thrive in dynamic environments where I can leverage my skills to deliver impactful products and drive team success. I am always eager to learn new technologies and apply them to create efficient and elegant solutions.
              </span>
            </div>
          </div>
        </div>
        <div className='container-experience'>
          <div className='container-experience-header'>
            <span>Professional Experience</span>
          </div>
          <div className='container-experience-content'>
            <div className='container-experience-content-title'>
              <span>Senior Software Engineer</span>
            </div>
            <div className='container-experience-content-subtitle'>
              <span>Tech Innovations Inc., New York, NY | Jan 2021 – Present</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Led the development of a real-time data streaming platform, reducing data latency by 40% and improving analytics capabilities.</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Designed and implemented a microservices architecture for user authentication, enhancing security and system scalability.</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Mentored junior engineers, fostering a collaborative environment and improving code quality across the team.</span>
            </div>
          </div>
          <div className='container-experience-content'>
            <div className='container-experience-content-title'>
              <span>Software Engineer</span>
            </div>
            <div className='container-experience-content-subtitle'>
              <span>Data Solutions Corp., San Francisco, CA | Aug 2018 – Dec 2020</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Developed and maintained RESTful APIs for customer-facing applications, serving over 100,000 daily users.</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Contributed to the migration of legacy systems to modern cloud infrastructure (AWS), resulting in a 25% cost reduction.</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Implemented automated testing procedures, leading to a 15% decrease in reported bugs post-deployment.</span>
            </div>
          </div>
        </div>
        <div className='container-skill'>
          <div className='container-skill-header'>
            <span>My Skills</span>
          </div>
          <div className='container-skill-content'>
            <div className='container-skill-section'>
              <span>Technical Proficiency</span>
              <div className='container-skill-item'>
                <div className='container-skill-item-header'>
                  <div>
                    <span>JavaScript</span>
                  </div>
                  <div>
                    <span>95%</span>
                  </div>
                </div>
                <div className="w-full h-3 bg-gray-300 rounded">
                  <div
                    className="h-3 bg-blue-700 rounded"
                    style={{
                      width: `${95}%`,
                      backgroundColor: '#224A72FF',
                    }}
                  ></div>
                </div>
              </div>
              <div className='container-skill-item'>
                <div className='container-skill-item-header'>
                  <div>
                    <span>TypeScript</span>
                  </div>
                  <div>
                    <span>80%</span>
                  </div>
                </div>
                <div className="w-full h-3 bg-gray-300 rounded">
                  <div
                    className="h-3 bg-blue-700 rounded"
                    style={{
                      width: `${80}%`,
                      backgroundColor: '#224A72FF',
                    }}
                  ></div>
                </div>
              </div>
            </div>
            <div className='container-skill-section'>
              <div><span>Skill Overview</span></div>
              <div style={{ width: '100%', height: 250, marginTop: '20px' }}>
              <ResponsiveContainer>
                <BarChart
                  layout="vertical"
                  data={data}
                  margin={{ top: 20, right: 30, left: 20, bottom: 20 }}>
                    <CartesianGrid strokeDasharray="3 3" />
                    <XAxis type="number" domain={[0, 100]} tickFormatter={(tick) => `${tick}%`} />
                    <YAxis dataKey="name" type="category" />
                    <Tooltip formatter={(value) => `${value}%`} />
                    <Bar
                      dataKey="value"
                      barSize={20}
                      radius={[5, 5, 5, 5]}>
                      {
                        data.map((entry, index) => (
                          <Cell key={`cell-${index}`} fill={entry.color} />
                        ))
                      }
                    </Bar>
                </BarChart>
              </ResponsiveContainer>
              </div>
              <div>
                <div>
                  <span>Soft Skill</span>
                </div>
                <div className='container-soft-skill'>
                  <div className='container-soft-skill-item'>
                    <span>Problem Solving</span>
                  </div>
                  <div className='container-soft-skill-item'>
                    <span>Teamwork</span>
                  </div>
                  <div className='container-soft-skill-item'>
                    <span>Communication</span>
                  </div>
                  <div className='container-soft-skill-item'>
                    <span>Adaptability</span>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div className='container-education'>
          <div className='container-education-header'>
            <span>Education</span>
          </div>
          <div className='container-education-content'>
            <div className='container-education-card'>
              <div className='container-education-card-title'>
                <span>Master of Science in Computer Science</span>
              </div>
              <div className='container-education-card-subtitle'>
                <span>University of Engineering, San Jose, CA | Sept 2014 – May 2016</span>
              </div>
              <div className='container-education-card-detail'>
                <span>Focused on advanced algorithms, distributed systems, and artificial intelligence.</span>
              </div>
            </div>
            <div className='container-education-card'>
              <div className='container-education-card-title'>
                <span>Bachelor of Science in Software Engineering</span>
              </div>
              <div className='container-education-card-subtitle'>
                <span>State University, San Jose, CA | Sept 2010 – May 2014</span>
              </div>
              <div className='container-education-card-detail'>
                <span>Specialized in software design patterns, database management, and web development frameworks.</span>
              </div>
            </div>
          </div>
        </div>
        <div className='container-featured-project'>
          <div className='container-featured-project-header'>
            <span>Featured Project</span>
          </div>
          <div className='container-featured-project-content'>
            <div className='container-featured-project-card'>
              <div className='container-featured-project-card-title'>
                <img className='container-featured-project-content-img' src='/images/chat-bot.png'></img>
                <div className='container-featured-project-content-title'>
                  <span>E-commerce Platform Redesign</span>
                </div>
              </div>
              <div className='container-featured-project-card-description'>
                <span>Revamped an existing e-commerce site using Next.js and Tailwind CSS, improving performance by 30% and conversion rates by 15%.</span>
              </div>
              <div className='container-featured-project-card-technology'>
                <div className='container-featured-project-card-technology-item'><span>ReactJS</span></div>
                <div className='container-featured-project-card-technology-item'><span>.Net</span></div>
                <div className='container-featured-project-card-technology-item'><span>SQL Server</span></div>
                <div className='container-featured-project-card-technology-item'><span>MongoDB</span></div>
                <div className='container-featured-project-card-technology-item'><span>Redis</span></div>
                <div className='container-featured-project-card-technology-item'><span>Azure Services Bus</span></div>
              </div>
            </div>
            <div className='container-featured-project-card'>
              <div className='container-featured-project-card-title'>
                <img className='container-featured-project-content-img' src='/images/nature-management.png' ></img>
                <div className='container-featured-project-content-title'>
                  <span>E-commerce Platform Redesign</span>
                </div>
              </div>
              <div className='container-featured-project-card-description'>
                <span>Revamped an existing e-commerce site using Next.js and Tailwind CSS, improving performance by 30% and conversion rates by 15%.</span>
              </div>
              <div className='container-featured-project-card-technology'>
                <div className='container-featured-project-card-technology-item'><span>ReactJS</span></div>
                <div className='container-featured-project-card-technology-item'><span>.Net</span></div>
                <div className='container-featured-project-card-technology-item'><span>SQL Server</span></div>
                <div className='container-featured-project-card-technology-item'><span>MongoDB</span></div>
                <div className='container-featured-project-card-technology-item'><span>Redis</span></div>
                <div className='container-featured-project-card-technology-item'><span>Azure Services Bus</span></div>
              </div>
            </div>
            <div className='container-featured-project-card'>
              <div className='container-featured-project-card-title'>
                <img className='container-featured-project-content-img' src='/images/real-estate.png'></img>
                <div className='container-featured-project-content-title'>
                  <span>E-commerce Platform Redesign</span>
                </div>
              </div>
              <div className='container-featured-project-card-description'>
                <span>Revamped an existing e-commerce site using Next.js and Tailwind CSS, improving performance by 30% and conversion rates by 15%.</span>
              </div>
              <div className='container-featured-project-card-technology'>
                <div className='container-featured-project-card-technology-item'><span>ReactJS</span></div>
                <div className='container-featured-project-card-technology-item'><span>.Net</span></div>
                <div className='container-featured-project-card-technology-item'><span>SQL Server</span></div>
                <div className='container-featured-project-card-technology-item'><span>MongoDB</span></div>
                <div className='container-featured-project-card-technology-item'><span>Redis</span></div>
                <div className='container-featured-project-card-technology-item'><span>Azure Services Bus</span></div>
              </div>
            </div>
            <div className='container-featured-project-card'>
              <div className='container-featured-project-card-title'>
                <img className='container-featured-project-content-img' src='/images/field-service-management.png'></img>
                <div className='container-featured-project-content-title'>
                  <span>E-commerce Platform Redesign</span>
                </div>
              </div>
              <div className='container-featured-project-card-description'>
                <span>Revamped an existing e-commerce site using Next.js and Tailwind CSS, improving performance by 30% and conversion rates by 15%.</span>
              </div>
              <div className='container-featured-project-card-technology'>
                <div className='container-featured-project-card-technology-item'><span>ReactJS</span></div>
                <div className='container-featured-project-card-technology-item'><span>.Net</span></div>
                <div className='container-featured-project-card-technology-item'><span>SQL Server</span></div>
                <div className='container-featured-project-card-technology-item'><span>MongoDB</span></div>
                <div className='container-featured-project-card-technology-item'><span>Redis</span></div>
                <div className='container-featured-project-card-technology-item'><span>Azure Services Bus</span></div>
              </div>
            </div>
          </div>
        </div>
        <div className='container-testimonial'>
          <div className='container-testimonial-header'>
            <span>Testimonials</span>
          </div>
          <div className='container-testimonial-content'>
            <div className='container-testimonial-card'>
              <div className='container-testimonial-card-avatar'>
                <img 
                  src="https://via.placeholder.com/120x120/3275B4/FFFFFF?text=A" 
                  alt="Alex Avatar" 
                  //className="avatar-image"
                />
              </div>
              <div className='container-testimonial-card-description'>
                <span>"Alex is an exceptionally talented engineer with a keen eye for detail and a strong commitment to delivering high-quality code. His contributions were invaluable to our team."</span>
              </div>
              <div className='container-testimonial-card-name'>
                <span>Jane Doe</span>
              </div>
              <div className='container-testimonial-card-title'>
                <span>Lead Software Architect at Tech Innovations Inc.</span>
              </div>
            </div>
            <div className='container-testimonial-card'>
              <div className='container-testimonial-card-avatar'>
                <image>a</image>
              </div>
              <div className='container-testimonial-card-description'>
                <span>"Alex is an exceptionally talented engineer with a keen eye for detail and a strong commitment to delivering high-quality code. His contributions were invaluable to our team."</span>
              </div>
              <div className='container-testimonial-card-name'>
                <span>Jane Doe</span>
              </div>
              <div className='container-testimonial-card-title'>
                <span>Lead Software Architect at Tech Innovations Inc.</span>
              </div>
            </div>
          </div>
        </div>
        <div className='container-contact'>
          <div className='container-contact-header'>
            <span>Get In Touch</span>
          </div>
          <div className='container-contact-content'>
            <div className='container-contact-content-information'>
              <div className='container-contact-content-information-title'>
                <span>Contact Information</span>
              </div>
              <div className='container-contact-content-information-description'>
                <span>alex@gmail.com</span>
              </div>
              <div className='container-contact-content-information-description'>
                <span>+84 373049513</span>
              </div>
              <div className='container-contact-content-information-description'>
                <span>Linkedin</span>
              </div>
              <div className='container-contact-content-information-description'>
                <span>Github</span>
              </div>
              <button className='container-contact-primary'>Download My CV</button>
            </div>
            <div className='container-contact-content-message'>
              <div className='container-contact-content-message-title'>
                <span>Send a Message</span>
              </div>
              <div className='container-contact-content-message-subtitle'>
                <span>I will get back to you as soon as possible.</span>
              </div>
              <div className='container-contact-content-message-description'>
                <input type='text' placeholder='Your Name'></input>
              </div>
              <div className='container-contact-content-message-description'>
                <input type='text' placeholder='Email'></input>
              </div>
              <div className='container-contact-content-message-description'>
                <input type='text' placeholder='Subject'></input>
              </div>
              <div className='container-contact-content-message-description'>
                <textarea placeholder='Message'></textarea>
              </div>
              <button className='container-contact-primary'>Send Message</button>
            </div>
          </div>
        </div>
      </div>
      <div className='footer'>

      </div>
    </div>
    </>
  )
}

export default App
