import { TestApiTemplatePage } from './app.po';

describe('TestApi App', function() {
  let page: TestApiTemplatePage;

  beforeEach(() => {
    page = new TestApiTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
