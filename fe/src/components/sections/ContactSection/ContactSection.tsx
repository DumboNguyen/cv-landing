import React, { useState } from 'react';
import Button from '../../common/Button/Button';
import { profileData } from '../../../data';
import './ContactSection.css';

const ContactSection: React.FC = () => {
  const [formData, setFormData] = useState({
    name: '',
    email: '',
    subject: '',
    message: ''
  });

  const handleInputChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    const { name, value } = e.target;
    setFormData(prev => ({
      ...prev,
      [name]: value
    }));
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    // Handle form submission logic here
    console.log('Form submitted:', formData);
  };

  const handleDownloadCV = () => {
    // Handle CV download logic here
    console.log('Downloading CV...');
  };

  return (
    <div className="container-contact">
      <div className="container-contact-header">
        <span>Get In Touch</span>
      </div>
      <div className="container-contact-content">
        <div className="container-contact-content-information">
          <div className="container-contact-content-information-title">
            <span>Contact Information</span>
          </div>
          <div className="container-contact-content-information-description">
            <span>{profileData.email}</span>
          </div>
          <div className="container-contact-content-information-description">
            <span>{profileData.phone}</span>
          </div>
          <div className="container-contact-content-information-description">
            <span>LinkedIn</span>
          </div>
          <div className="container-contact-content-information-description">
            <span>Github</span>
          </div>
          <Button 
            variant="primary" 
            onClick={handleDownloadCV}
            className="container-contact-primary"
          >
            Download My CV
          </Button>
        </div>
        <div className="container-contact-content-message">
          <div className="container-contact-content-message-title">
            <span>Send a Message</span>
          </div>
          <div className="container-contact-content-message-subtitle">
            <span>I will get back to you as soon as possible.</span>
          </div>
          <form onSubmit={handleSubmit} className="contact-form">
            <div className="container-contact-content-message-description">
              <input
                type="text"
                name="name"
                placeholder="Your Name"
                value={formData.name}
                onChange={handleInputChange}
                required
              />
            </div>
            <div className="container-contact-content-message-description">
              <input
                type="email"
                name="email"
                placeholder="Email"
                value={formData.email}
                onChange={handleInputChange}
                required
              />
            </div>
            <div className="container-contact-content-message-description">
              <input
                type="text"
                name="subject"
                placeholder="Subject"
                value={formData.subject}
                onChange={handleInputChange}
                required
              />
            </div>
            <div className="container-contact-content-message-description">
              <textarea
                name="message"
                placeholder="Message"
                value={formData.message}
                onChange={handleInputChange}
                required
              />
            </div>
            <Button 
              type="submit" 
              variant="primary"
              className="container-contact-primary"
            >
              Send Message
            </Button>
          </form>
        </div>
      </div>
    </div>
  );
};

export default ContactSection;
