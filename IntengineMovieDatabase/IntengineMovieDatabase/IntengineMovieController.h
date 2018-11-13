#import <Cocoa/Cocoa.h>
#import "iCarousel.h"

@interface iCarouselWindowController : NSWindowController <iCarouselDataSource, iCarouselDelegate>

@property (nonatomic, strong) IBOutlet iCarousel *carousel;

- (IBAction)switchCarouselType:(id)sender;
- (IBAction)toggleVertical:(id)sender;
- (IBAction)toggleWrap:(id)sender;
- (IBAction)insertItem:(id)sender;
- (IBAction)removeItem:(id)sender;

@end
